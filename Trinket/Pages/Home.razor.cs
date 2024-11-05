using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using Radzen.Blazor;
using Trinket.Data;

namespace Trinket.Pages;

public partial class Home
{
    private const int Level = 80;

    [SupplyParameterFromQuery(Name = "trinkets")]
    public string? SelectedTrinkets
    {
        get => string.Join(",", _selectedTrinkets ?? Enumerable.Empty<string>());
        set => _selectedTrinkets = value?.Split(',').Select(t => t.Trim()).ToList();
    }

    [SupplyParameterFromQuery(Name = "specs")]
    public string? SelectedSpecs
    {
        get => string.Join(",", _selectedSpecs ?? Enumerable.Empty<string>());
        set => _selectedSpecs = value?.Split(',').Select(t => t.Trim()).ToList();
    }

    [SupplyParameterFromQuery(Name = "groupbyspec")]
    public string? GroupBySpec
    {
        get => _groupBySpec ? "1" : "0";
        set => _groupBySpec = value == "1";
    }

    [SupplyParameterFromQuery(Name = "itemlevel")]
    public string? ItemLevel
    {
        get => _itemLevel?.ToString();
        set => _itemLevel = int.TryParse(value, out var ilvl) ? ilvl : null;
    }

    private readonly Data[]                _data;
    private          RadzenDataGrid<Data>? _dataGrid;
    private          bool                  _groupBySpec;
    private          List<string>?         _selectedTrinkets;
    private          List<string>?         _selectedSpecs;
    private          int?                  _itemLevel;

    public Home()
    {
        _data = TrinketData.Trinkets.SelectMany(t => t.Value, (t, td) => new Data(t.Key, td.Key, td.Value)).ToArray();
    }

    protected override void OnParametersSet()
    {
        _itemLevel ??= 619;
    }

    private async Task UpdateHistory()
    {
        // Update URL
        var sb = new StringBuilder("groupbyspec=");
        sb.Append(_groupBySpec ? "1" : "0");

        if (_selectedTrinkets is not null)
            sb.Append(sb.Length > 0 ? "&" : "")
              .Append("trinkets=")
              .Append(SelectedTrinkets);

        if (_selectedSpecs is not null)
            sb.Append(sb.Length > 0 ? "&" : "")
              .Append("specs=")
              .Append(SelectedSpecs);

        if (_itemLevel.HasValue)
            sb.Append(sb.Length > 0 ? "&" : "")
              .Append("itemlevel=")
              .Append(_itemLevel);

        await JSRuntime.InvokeVoidAsync("history.pushState", null, "", sb.Length > 0 ? $"?{sb}" : "?");
    }

    private async Task FilterChanged()
    {
        if (_dataGrid is null)
            return;

        // Clear empty filters
        if (_selectedTrinkets is {Count: <= 0})
            _selectedTrinkets = null;
        if (_selectedSpecs is {Count: <= 0})
            _selectedSpecs = null;

        await UpdateHistory();

        // Setup grouping
        _dataGrid.Groups.Clear();
        if (_groupBySpec)
            _dataGrid.Groups.Add(new GroupDescriptor
            {
                Title     = "Specialization / Class",
                Property  = "Spec",
                SortOrder = SortOrder.Ascending
            });
        else
            _dataGrid.Groups.Add(new GroupDescriptor
            {
                Title     = "Trinket",
                Property  = "Name",
                SortOrder = SortOrder.Ascending
            });

        // Refresh
        await _dataGrid.Reload();
        StateHasChanged();
    }

    private void Render(DataGridRenderEventArgs<Data> args)
    {
        if (!args.FirstRender)
            return;

        args.Grid.Sorts.Add(new SortDescriptor
        {
            Property  = "TierNumerical",
            SortOrder = SortOrder.Ascending
        });
        args.Grid.Sorts.Add(new SortDescriptor
        {
            Property  = "Spec",
            SortOrder = SortOrder.Ascending
        });

        if (_groupBySpec)
            args.Grid.Groups.Add(new GroupDescriptor
            {
                Title     = "Specialization / Class",
                Property  = "Spec",
                SortOrder = SortOrder.Ascending
            });
        else
            args.Grid.Groups.Add(new GroupDescriptor
            {
                Title     = "Trinket",
                Property  = "Name",
                SortOrder = SortOrder.Ascending
            });

        StateHasChanged();
    }

    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    private class Data(string? name, string? spec, TierModel model)
    {
        public string? Name          { get; } = name;
        public string? Spec          { get; } = spec;
        public string? Tier          => model.Tier;
        public int     TierNumerical => model.TierNumerical;
        public string? Icon          => model.Icon;
        public string? Link          => model.Link;
        public string? Note          => model.Note;
    }
}
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

    private readonly Data[]                                _data;
    private          bool                                  _groupBySpec;
    private          RadzenDropDownDataGrid<List<string>>? _trinketGrid;
    private          List<string>?                         _selectedTrinkets;
    private          RadzenDropDownDataGrid<List<string>>? _specGrid;
    private          List<string>?                         _selectedSpecs;
    private          int?                                  _itemLevel;
    private          RadzenDataGrid<Data>?                 _dataGrid;

    private bool? AllTrinketChecked
    {
        get
        {
            {
                if (_selectedTrinkets is null || _trinketGrid is null)
                    return false;

                var total   = 0;
                var counter = 0;
                foreach (var data in _trinketGrid.DataGrid.Data)
                {
                    if (_selectedTrinkets.Contains((string)data))
                        counter++;
                    total++;
                }

                return counter == total
                           ? true
                           : counter > 0
                               ? null
                               : false;
            }
        }

        set
        {
            if (_trinketGrid is null)
                return;

            var data = _trinketGrid.DataGrid.Data.Cast<string>().ToArray();
            if (data.Length <= 0 && value is false)
                return;

            if (value is true or null)
            {
                _selectedTrinkets ??= [];
                _selectedTrinkets.AddRange(data.Except(_selectedTrinkets));
            }
            else
            {
                _selectedTrinkets = _selectedTrinkets?.Except(data).ToList();
            }

            _ = FilterChanged();
        }
    }

    private bool? AllSpecChecked
    {
        get
        {
            {
                if (_selectedSpecs is null || _specGrid is null)
                    return false;

                var total   = 0;
                var counter = 0;
                foreach (var data in _specGrid.DataGrid.Data)
                {
                    if (_selectedSpecs.Contains((string) data))
                        counter++;
                    total++;
                }

                return counter == total
                           ? true
                           : counter > 0
                               ? null
                               : false;
            }
        }

        set
        {
            if (_specGrid is null)
                return;

            var data = _specGrid.DataGrid.Data.Cast<string>().ToArray();
            if (data.Length <= 0 && value is false)
                return;

            if (value is true or null)
            {
                _selectedSpecs ??= [];
                _selectedSpecs.AddRange(data.Except(_selectedSpecs));
            }
            else
            {
                _selectedSpecs = _selectedSpecs?.Except(data).ToList();
            }

            _ = FilterChanged();
        }
    }

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

    #region Query parameters
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
    #endregion
}
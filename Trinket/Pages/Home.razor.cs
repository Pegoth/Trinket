using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Trinket.Data;

namespace Trinket.Pages;

public partial class Home
{
    private Dictionary<string, Dictionary<string, TierModel>>? _results = TrinketData.Trinkets;

    [SupplyParameterFromQuery(Name = "trinket")]
    private string? TrinketFilter { get; set; }

    [SupplyParameterFromQuery(Name = "spec")]
    private string? SpecFilter { get; set; }

    protected override Task OnParametersSetAsync() => Search();

    private async Task FilterKeyUp(KeyboardEventArgs arg)
    {
        if (arg is {AltKey: false, CtrlKey: false, MetaKey: false, ShiftKey: false, Key: "Enter"})
            await Search();
    }

    private async Task ClearTrinketFilter()
    {
        TrinketFilter = "";
        await Search();
    }

    private async Task ClearSpecFilter()
    {
        SpecFilter = "";
        await Search();
    }

    private async Task Search()
    {
        try
        {
            // Update URL
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(TrinketFilter))
                sb.Append("trinket=")
                  .Append(TrinketFilter);
            if (!string.IsNullOrEmpty(SpecFilter))
                sb.Append(sb.Length > 0 ? "&" : "")
                  .Append("spec=")
                  .Append(SpecFilter);
            await JSRuntime.InvokeVoidAsync("history.pushState", null, "", sb.Length > 0 ? $"?{sb}" : "?");

            // Check filters
            if (string.IsNullOrEmpty(TrinketFilter) && string.IsNullOrEmpty(SpecFilter))
            {
                _results = TrinketData.Trinkets;
                return;
            }

            var tf = TrinketFilter?.ToLower().Split(" ");
            var sf = SpecFilter?.ToLower().Split(" ");
            _results = TrinketData.Trinkets
                                  .Where(kv =>
                                   {
                                       if (tf == null)
                                           return true;
                                       var key = kv.Key.ToLower().Split(" ");
                                       return tf.All(f => key.Any(t => t.Contains(f)));
                                   })
                                  .ToDictionary(
                                       kv => kv.Key,
                                       kv => kv.Value
                                               .Where(tm =>
                                                {
                                                    if (sf == null)
                                                        return true;

                                                    var key = tm.Key.ToLower().Split(" ");
                                                    return sf.All(f => key.Any(c => c.Contains(f)));
                                                })
                                               .ToDictionary(a => a.Key, a => a.Value));
        }
        finally
        {
            await InvokeAsync(StateHasChanged);
        }
    }
}
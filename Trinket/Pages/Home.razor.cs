using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Trinket.Data;

namespace Trinket.Pages;

public partial class Home
{
    private string?                                            _trinketFilter;
    private string?                                            _specFilter;
    private Dictionary<string, Dictionary<string, TierModel>>? _results = TrinketData.Trinkets;

    [SupplyParameterFromQuery(Name = "trinket")]
    private string? TrinketFilter
    {
        get => _trinketFilter;
        set
        {
            _trinketFilter = value;
            Search();
        }
    }

    [SupplyParameterFromQuery(Name = "spec")]
    private string? SpecFilter
    {
        get => _specFilter;
        set
        {
            _specFilter = value;
            Search();
        }
    }

    private void Search()
    {
        try
        {
            // Update URL
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(_trinketFilter))
                sb.Append("trinket=")
                  .Append(_trinketFilter);
            if (!string.IsNullOrEmpty(_specFilter))
                sb.Append(sb.Length > 0 ? "&" : "")
                  .Append("spec=")
                  .Append(_specFilter);
            JSRuntime.InvokeVoidAsync("history.pushState", null, "", sb.Length > 0 ? $"?{sb}" : "/");

            // Check filters
            if (string.IsNullOrEmpty(_trinketFilter) && string.IsNullOrEmpty(_specFilter))
            {
                _results = TrinketData.Trinkets;
                return;
            }

            var tf = _trinketFilter?.ToLower().Split(" ");
            var sf = _specFilter?.ToLower().Split(" ");
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
            InvokeAsync(StateHasChanged);
        }
    }
}
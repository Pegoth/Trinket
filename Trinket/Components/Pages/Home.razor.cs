using System.Text.Json;
using System.Text.Json.Serialization;

namespace Trinket.Components.Pages;

public partial class Home
{
    private string?                                            _error;
    private string?                                            _trinketFilter;
    private string?                                            _classFilter;
    private Dictionary<string, Dictionary<string, TierModel>>? _trinkets;
    private Dictionary<string, Dictionary<string, TierModel>>? _results;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _trinkets = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, TierModel>>>(await File.ReadAllTextAsync("trinkets.json"));
            _results  = _trinkets;
        }
        catch (Exception ex)
        {
            _error = ex.Message;
        }
    }

    private async Task Search()
    {
        try
        {
            if (_trinkets == null || string.IsNullOrEmpty(_trinketFilter) && string.IsNullOrEmpty(_classFilter))
            {
                _results = _trinkets;
                return;
            }

            var tf = _trinketFilter?.ToLower().Split(" ");
            var cf = _classFilter?.ToLower().Split(" ");
            _results = _trinkets.Where(kv =>
                                 {
                                     if (tf == null)
                                         return true;
                                     var key = kv.Key.ToLower().Split(" ");
                                     return tf.All(f => key.Any(t => t.Contains(f)));
                                 })
                                .ToDictionary(
                                     kv => kv.Key,
                                     kv => kv.Value
                                             .Where(skv =>
                                              {
                                                  if (cf == null)
                                                      return true;

                                                  var key = skv.Key.ToLower().Split(" ");
                                                  return cf.All(f => key.Any(c => c.Contains(f)));
                                              })
                                             .ToDictionary());
        }
        finally
        {
            await InvokeAsync(StateHasChanged);
        }
    }

    private class TierModel
    {
        [JsonInclude]
        [JsonPropertyName("tier")]
        public string? Tier { get; set; }

        [JsonIgnore]
        public int TierNumerical
        {
            get
            {
                var tier = Tier?.TrimStart().ToLower();
                if (string.IsNullOrEmpty(tier))
                    return int.MaxValue;

                // Get the base value
                var value = tier[..1] switch
                {
                    "s" => 1,
                    "a" => 4,
                    "b" => 7,
                    "c" => 10,
                    "d" => 13,
                    "e" => 16,
                    "f" => 19,
                    _ => int.MaxValue
                };

                // Check if it is possible to have a modifier or not
                if (tier.Length <= 1)
                    return value;

                // Change based on modifier
                switch (tier[1])
                {
                    case '-':
                        value++;
                        break;
                    case '+':
                        value--;
                        break;
                }

                return value;
            }
        }

        [JsonInclude]
        [JsonPropertyName("note")]
        public string? Note { get; set; }
    }
}
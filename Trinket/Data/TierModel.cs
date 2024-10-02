using System.Text.Json.Serialization;

namespace Trinket.Data;

public class TierModel
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
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonInclude]
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonInclude]
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    public TierModel()
    {
    }

    public TierModel(string? tier, string? icon, string? link, string? note)
    {
        Tier = tier;
        Icon = icon;
        Link = link;
        Note = note;
    }
}
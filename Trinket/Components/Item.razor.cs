using System.Text;
using Microsoft.AspNetCore.Components;

namespace Trinket.Components;

public partial class Item
{
    [Parameter]
    public string? Link { get; set; }

    [Parameter]
    public string? Name { get; set; }

    [Parameter]
    public string? Icon { get; set; }

    [Parameter]
    public int? Level { get; set; }

    [Parameter]
    public int? ItemLevel { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string WowheadLink
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Link))
                return string.Empty;

            var sb = new StringBuilder(Link);

            if (Level is not null)
                sb.Append("?lvl=")
                  .Append(Level);

            if (ItemLevel is not null)
                sb.Append(Level is null ? "?" : "&")
                  .Append("ilvl=")
                  .Append(ItemLevel);

            return sb.ToString();
        }
    }
}
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

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }
}
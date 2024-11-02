using Microsoft.JSInterop;

namespace Trinket.Layout;

public partial class MainLayout
{
    private bool _sidebarExpanded;
    private bool _isLight;

    protected override async Task OnInitializedAsync()
    {
        var cookie = await JSRuntime.InvokeAsync<string>("getCookie", ["isLight"]);
        if (string.IsNullOrWhiteSpace(cookie) || cookie.Equals("true", StringComparison.OrdinalIgnoreCase))
            _isLight = true;
    }

    private async Task ModeChange(bool value)
    {
        _isLight = value;
        await JSRuntime.InvokeVoidAsync("setCookie", "isLight", value.ToString().ToLower());
    }
}
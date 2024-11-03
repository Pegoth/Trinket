using Microsoft.JSInterop;

namespace Trinket.Layout;

public partial class MainLayout
{
    private bool _sidebarExpanded;
    private bool _isLight;

    protected override async Task OnInitializedAsync()
    {
        _isLight = await JSRuntime.InvokeAsync<bool>("lightMode");
    }

    private async Task ModeChange(bool value)
    {
        _isLight = value;
        await JSRuntime.InvokeVoidAsync("lightMode", value);
    }
}
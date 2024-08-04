using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Layout;

public partial class AppSidebar : ComponentBase
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = null!;

    protected override void OnInitialized()
    {
        NavigationManager.LocationChanged += (sender, args) => StateHasChanged();
        
        base.OnInitialized();
    }

    private bool CheckIfPageIsCurrent(string page)
    {
        return NavigationManager.Uri.Replace(NavigationManager.BaseUri, "") == page;
    }
}

using BlazorUiKit.Utils;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.UiKit.Form;

public partial class Switch : ComponentBase
{
    [Parameter][EditorRequired]
    public bool Checked { get; set; } = false;
    
    [Parameter][EditorRequired]
    public EventCallback<bool> OnChange { get; set; }

    private string CssClass { get; set; } = string.Empty;

    protected override void OnInitialized()
    {
        SetupCssClass();
        base.OnInitialized();
    }
    
    protected override void OnParametersSet()
    {
        SetupCssClass();
        base.OnParametersSet();
    }

    private Task HandleClick()
    {
        OnChange.InvokeAsync(!Checked);
        return Task.CompletedTask;
    }
    
    private void SetupCssClass()
    {
        CssClass = CssUtils.ConstructClassNames("switch", ("active", Checked));
    }
}


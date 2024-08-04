using BlazorUiKit.Utils;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.UiKit.Form;

public partial class Switch : ComponentBase
{
    [Parameter]
    [EditorRequired]
    public bool Checked { get; set; }

    [Parameter]
    [EditorRequired]
    public EventCallback<bool> OnChange { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    private string CssClass =>
        CssUtils.ConstructClassNames(
            "switch",
            ("checked", Checked),
            ("disabled", Disabled)
        );

    private Task HandleClick()
    {
        OnChange.InvokeAsync(!Checked);
        return Task.CompletedTask;
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorUiKit.Utils;

namespace BlazorUiKit.UiKit.Buttons;

public enum ButtonVariantsEnum
{
    Primary,
    Secondary
}

public partial class Button : ComponentBase
{
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = default!;

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public ButtonVariantsEnum Variant { get; set; } = ButtonVariantsEnum.Primary;

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public EventCallback OnClick { get; set; }

    private string CssClass => CssUtils.ConstructClassNames(
    "btn",
    ("primary", Variant == ButtonVariantsEnum.Primary),
    ("secondary", Variant == ButtonVariantsEnum.Secondary),
    ("disabled", Disabled)
    );
}

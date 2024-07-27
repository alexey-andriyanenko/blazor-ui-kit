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
    public bool Disabled { get; set; } = false;
    
    [Parameter]
    public EventCallback OnClick { get; set; }
    
    private string CssClass { get; set; } = string.Empty;

    protected override Task OnInitializedAsync()
    {
        CssClass = CssUtils.ConstructClassNames(
            "btn",
            GetVariantCssClass(),
            ("disabled", Disabled)
        );
        
        StateHasChanged();
        
        return base.OnInitializedAsync();
    }

    private string GetVariantCssClass()
    {
        return Variant switch
        {
            ButtonVariantsEnum.Primary => "btn-primary",
            ButtonVariantsEnum.Secondary => "btn-secondary",
            _ => "btn-primary"
        };
    }
}


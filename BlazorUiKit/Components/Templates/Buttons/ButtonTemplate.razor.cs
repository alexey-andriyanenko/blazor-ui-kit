using BlazorUiKit.Components.Controls;
using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;
using BlazorUiKit.UiKit.Buttons;

namespace BlazorUiKit.Components.Templates.Buttons;

public partial class ButtonTemplate : ComponentBase
{
    private IList<IControl> Controls { get; set; } = new List<IControl>();
    private Dictionary<string, object> ButtonParameters { get; set; } = new();

    protected override void OnInitialized()
    {
        ConstructButtonParams();
        ConstructControls();
        
        base.OnInitialized();
    }

    private void ConstructButtonParams()
    {
        var buttonParameters = new Dictionary<string, object>();
        
        buttonParameters.Add(nameof(Button.Disabled), false);

        buttonParameters.Add(nameof(Button.Variant), ButtonVariantsEnum.Primary);
        
        buttonParameters.Add(nameof(Button.ChildContent), (RenderFragment)(builder =>
        {
            builder.AddContent(0, "Click me!");
        }));
        
        ButtonParameters = buttonParameters;
    }


    private void ConstructControls()
    {
        var controlModels = new List<IControl>();
        
        controlModels.Add(new ControlBooleanModel
        {
            Name = nameof(Button.Disabled),
            ComponentType = typeof(ControlBoolean),
            ComponentParameters = new()
            {
                { nameof(ControlBoolean.OnChange), EventCallback.Factory.Create<bool>(this, HandleDisabledChange  )}
            }
        });

        controlModels.Add(new ControlReadOnlyModel
        {
            Name = nameof(Button.OnClick),
            ComponentType = typeof(ControlReadonly),
            TypeName = nameof(EventCallback)
        });
        
        controlModels.Add(new ControlEnumModel
        {
            Name = nameof(Button.Variant),
            TypeName = nameof(ButtonVariantsEnum),
            ComponentType = typeof(ControlEnum<ButtonVariantsEnum>),
            ComponentParameters = new()
            {
                { nameof(ControlEnum<ButtonVariantsEnum>.EnumType), typeof(ButtonVariantsEnum) },
                { nameof(ControlEnum<ButtonVariantsEnum>.OnChange), EventCallback.Factory.Create<ButtonVariantsEnum>(this,  HandleButtonVariantChange )}
            }
        });
        
        controlModels.Add(new ControlReadOnlyModel
        {
            Name = nameof(Button.ChildContent),
            ComponentType = typeof(ControlReadonly),
            TypeName = nameof(RenderFragment)
        });
        
        Controls = controlModels;
    }
    
    private void HandleButtonVariantChange(ButtonVariantsEnum variant)
    {
        ButtonParameters[nameof(Button.Variant)] = variant;
    }
    
    private void HandleDisabledChange(bool disabled)
    {
        ButtonParameters[nameof(Button.Disabled)] = disabled;
    }
}


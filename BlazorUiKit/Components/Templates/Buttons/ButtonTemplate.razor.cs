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
        ButtonParameters.Add(nameof(Button.Disabled), false);
        Controls.Add(new ControlBooleanModel
        {
            Name = nameof(Button.Disabled),
        });
        
        
        ButtonParameters.Add(nameof(Button.OnClick), EventCallback.Factory.Create(this, () => Console.WriteLine("Button clicked!")));
        Controls.Add(new ControlReadOnlyModel
        {
           Name = nameof(Button.OnClick),
           TypeName = nameof(EventCallback)
        });

        var variantControl = new ControlEnumModel
        {
            Name = nameof(Button.Variant),
            TypeName = nameof(ButtonVariantsEnum),
            Enum = typeof(ButtonVariantsEnum)
        };
        variantControl.ComponentParameters.Add(nameof(ControlEnum.Model), variantControl);
        ButtonParameters.Add(nameof(Button.Variant), ButtonVariantsEnum.Primary);
        Controls.Add(variantControl);
        
        ButtonParameters.Add(nameof(Button.ChildContent), (RenderFragment)(builder =>
        {
            builder.AddContent(0, "Click me!");
        }));
        Controls.Add(new ControlReadOnlyModel
        {
            Name = nameof(Button.ChildContent),
            TypeName = nameof(RenderFragment)
        });
        
        
        base.OnInitialized();
    }
}


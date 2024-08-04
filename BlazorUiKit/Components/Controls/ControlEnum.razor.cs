using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public class ControlEnumOption<TEnum> where TEnum : Enum
{
    public string Name { get; init; }
    public TEnum Value { get; init; }
}

public partial class ControlEnum<TEnum> : ComponentBase where TEnum : Enum
{
    [Parameter][EditorRequired]
    public Type EnumType { get; set; }
    
    [Parameter][EditorRequired]
    public EventCallback<TEnum> OnChange { get; set; }

    private TEnum Value { get; set; }
    
    private IList<ControlEnumOption<TEnum>> SelectOptions { get; set; } = new List<ControlEnumOption<TEnum>>();

    protected override void OnInitialized()
    {
        SelectOptions = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(value => new ControlEnumOption<TEnum>
        {
            Name = value.ToString(),
            Value = value
        }).ToList();

        base.OnInitialized();
    }
}

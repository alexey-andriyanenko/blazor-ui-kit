using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.UiKit.Form;

public enum InputFieldVariantsEnum
{
    Primary
}

public enum InputFieldTypesEnum
{
    Text,
    Password,
    Email,
    Number
}

public partial class InputField : ComponentBase
{
    [Parameter]
    public InputFieldTypesEnum Type { get; set; } = InputFieldTypesEnum.Text;
    
    [Parameter]
    public InputFieldVariantsEnum Variant { get; set; } = InputFieldVariantsEnum.Primary;
    
    [Parameter]
    public bool Disabled { get; set; } = false;
    
    [Parameter]
    public bool ReadOnly { get; set; } = false;
    
    private string TypeValue => Type switch
    {
        InputFieldTypesEnum.Text => "text",
        InputFieldTypesEnum.Password => "password",
        InputFieldTypesEnum.Email => "email",
        InputFieldTypesEnum.Number => "number",
        _ => "text"
    };

    private string Value { get; set; } = "HELLo";
    
    private Task HandleInput(ChangeEventArgs e)
    {
        Value = e.Value?.ToString() ?? string.Empty;
        return Task.CompletedTask;
    }
}


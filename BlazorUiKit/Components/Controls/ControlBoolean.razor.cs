using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlBoolean : ComponentBase
{
    [Parameter]
    public EventCallback<bool> OnChange { get; set; }
    
    private bool Value { get; set; }

    private void HandleChange()
    {
        Value = !Value;
        OnChange.InvokeAsync(Value);
    }
}

using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlBoolean : ComponentBase
{
    [Parameter][EditorRequired]
    public ControlBooleanModel Model { get; set; } = null!;
    
    private bool Value { get; set; } = false;
}


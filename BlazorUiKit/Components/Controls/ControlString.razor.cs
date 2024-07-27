using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlString : ComponentBase
{
    [Parameter][EditorRequired]
    public ControlStringModel Model { get; set; } = null!;
    
    private string Value { get; set; } = string.Empty;
}


using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlNumber : ComponentBase
{
    [Parameter][EditorRequired]
    public int Value { get; set; }
    
    [Parameter][EditorRequired]
    public EventCallback<int> OnChange { get; set; }
}

using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlNumber : ComponentBase
{
    [Parameter][EditorRequired]
    public ControlNumberModel Model { get; set; } = null!;

    private int Value { get; set; } = default;
}

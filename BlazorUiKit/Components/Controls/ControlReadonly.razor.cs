using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlReadonly : ComponentBase
{
    [Parameter][EditorRequired]
    public ControlReadOnlyModel Model { get; set; } = null!;
}


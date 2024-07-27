using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public partial class ControlsList : ComponentBase
{
    [Parameter]
    public IEnumerable<IControl> Controls { get; set; } = Array.Empty<IControl>();
    
    protected override void OnInitialized()
    {
        base.OnInitialized();
    }
}


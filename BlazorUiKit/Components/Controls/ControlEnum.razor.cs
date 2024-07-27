using BlazorUiKit.Components.Controls.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUiKit.Components.Controls;

public class ControlEnumOption {
    public string Name { get; init; }
    public int Value { get; init; }
}

public partial class ControlEnum : ComponentBase
{
    [Parameter][EditorRequired]
    public ControlEnumModel Model { get; set; }
    
    private string SelectedValue { get; set; } = string.Empty;

    private IList<ControlEnumOption> SelectOptions { get; set; } = new List<ControlEnumOption>();
    
    protected override void OnInitialized()
    {
        var names = Enum.GetNames(Model.Enum);
        var values = Enum.GetValues(Model.Enum);
        
        for (var i = 0; i < names.Length; i++)
        {
            SelectOptions.Add(new ControlEnumOption
            {
                Name = names[i],
                Value = (int)values.GetValue(i)
            });    
        }
        
        base.OnInitialized();
    }
}

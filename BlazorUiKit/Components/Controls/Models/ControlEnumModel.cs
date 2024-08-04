namespace BlazorUiKit.Components.Controls.Models;

public class ControlEnumModel : IControl
{
    public required string Name { get; set; }
    public required string TypeName { get; set; }
    public required Type ComponentType { get; set; }
    public Dictionary<string, object>? ComponentParameters { get; set; }
}

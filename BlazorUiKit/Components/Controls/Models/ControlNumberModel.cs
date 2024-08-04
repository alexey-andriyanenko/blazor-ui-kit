namespace BlazorUiKit.Components.Controls.Models;

public class ControlNumberModel : IControl
{
    public required string Name { get; set; }
    public string TypeName { get; set; } = "number";
    public required Type ComponentType { get; set; }
    public Dictionary<string, object>? ComponentParameters { get; set; }
}
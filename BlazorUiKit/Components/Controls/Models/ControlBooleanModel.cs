namespace BlazorUiKit.Components.Controls.Models;

public class ControlBooleanModel : IControl
{
    public required string Name { get; set; }
    public string TypeName { get; set; } = "boolean";
    public required Type ComponentType { get; set; }
    public Dictionary<string, object>? ComponentParameters { get; set; }
}
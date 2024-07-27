namespace BlazorUiKit.Components.Controls.Models;

public class ControlNumberModel : IControl
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = "number";
    public Type ComponentType { get; set; } = typeof(ControlNumber);
    public Dictionary<string, object> ComponentParameters { get; set; } = new();
}
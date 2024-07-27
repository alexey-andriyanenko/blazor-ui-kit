namespace BlazorUiKit.Components.Controls.Models;

public class ControlBooleanModel : IControl
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = "boolean";
    public Type ComponentType { get; set; } = typeof(ControlBoolean);
    public Dictionary<string, object> ComponentParameters { get; set; } = new();
}
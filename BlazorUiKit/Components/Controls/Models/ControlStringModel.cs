namespace BlazorUiKit.Components.Controls.Models;

public class ControlStringModel : IControl
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = "string";
    public Type ComponentType { get; set; } = typeof(ControlString);
    public Dictionary<string, object> ComponentParameters { get; set; } = new();
}
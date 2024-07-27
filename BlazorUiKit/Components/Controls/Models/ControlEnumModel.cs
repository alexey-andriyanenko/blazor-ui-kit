namespace BlazorUiKit.Components.Controls.Models;

public class ControlEnumModel : IControl
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = "enum";
    public Type ComponentType { get; set; } = typeof(ControlEnum);
    public Dictionary<string, object> ComponentParameters { get; set; } = new();
    public Type Enum { get; set; }
    
}

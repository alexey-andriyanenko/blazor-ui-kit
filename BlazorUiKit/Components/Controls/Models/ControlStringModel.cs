namespace BlazorUiKit.Components.Controls.Models;

public class ControlStringModel : IControl
{
    public required string Name { get; set; }
    public string TypeName { get; set; } = "string";
    public required Type ComponentType { get; set; }
    public Dictionary<string, object>? ComponentParameters { get; set; }
}
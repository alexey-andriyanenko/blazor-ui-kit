namespace BlazorUiKit.Components.Controls.Models;

public class ControlReadOnlyModel : IControl
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty;
    public Type ComponentType { get; set; } = typeof(ControlReadonly);
    public Dictionary<string, object> ComponentParameters { get; set; } = new();
}
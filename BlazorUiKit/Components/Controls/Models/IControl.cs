namespace BlazorUiKit.Components.Controls.Models;

public interface IControl
{
    public string Name { get; set; }
    public string TypeName { get; set; }
    public Type ComponentType { get; set; }
    public Dictionary<string, object> ComponentParameters { get; set; }
}
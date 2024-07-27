using BlazorUiKit.Components.Controls;
using BlazorUiKit.Components.Controls.Models;
using BlazorUiKit.UiKit.Form;

namespace BlazorUiKit.Pages;


public enum ExampleEnum
{
    One,
    Two,
    Three
}

public class ComponentMetadata
{
    public required Type Type { get; set; }
    public required Dictionary<string, object> Parameters { get; set; }
}

public partial class Home
{
}

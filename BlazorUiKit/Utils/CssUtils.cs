namespace BlazorUiKit.Utils;

public static class CssUtils
{
    public static string ConstructClassNames(params object[] classNames)
    {
        IList<string> resultClassNames = new List<string>();

        foreach (var className in classNames)
        {
            if (className is string name)
            {
                resultClassNames.Add(name);
            }

            if (className is ValueTuple<string, bool> { Item2: true } tuple)
            {
                resultClassNames.Add(tuple.Item1);
            }
        }

        return string.Join(" ", resultClassNames);
    }
}

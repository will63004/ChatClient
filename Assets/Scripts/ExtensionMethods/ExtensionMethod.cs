using System.Collections.Generic;

public static partial class ExtensionMethod
{
    public static bool IsContainIndex<T>(this List<T> list, int index)
    {
        return list.Count > index;
    }
}

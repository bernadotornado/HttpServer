using System.Collections.Generic;
using System.Numerics;

namespace JSXCore.lib;

public class Reactive<T>
{
    public BigInteger id;
    public static List<Reactive<T>> ReactiveVariables = new();
    private T _value;
    public T Value
    {
        get => _value;
        set => _value = value;
    }

    private string jsName;
    
    public Reactive(T value)
    {
        Value = value;
        id = ReactiveVariables.Count;
        ReactiveVariables.Add(this);
        jsName = $"_reactive{id}";
        Component.jsCache += $"let {jsName} = {value};";
    }

    public override string ToString()
    {
        return jsName;
    }
}
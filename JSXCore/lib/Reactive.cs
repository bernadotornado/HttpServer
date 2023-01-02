using System.Collections.Generic;
using System.Numerics;

namespace JSXCore.lib;

public class Reactive<T>
{
    private BigInteger _id;
    private static List<Reactive<T>> _reactiveVariables = new();
    public T Value { get; set; }

    private string _jsName;
    public override string ToString() => _jsName;
    public Reactive(T value)
    {
        Value = value;
        _id = _reactiveVariables.Count;
        _reactiveVariables.Add(this);
        _jsName = $"_reactive{_id}";
        Component.JsCache += $"let {_jsName} = {value};";
    }

    
    
}
using System.Numerics;

namespace JSXCore;

public class Reactive<T>
{
    private readonly BigInteger _id;
    private static readonly List<Reactive<T>> ReactiveVariables = new();
    private readonly string _jsName;
    public override string ToString() => _jsName;
    public T Value;        
    public Reactive(T value)
    {
        Value = value;
        _id = ReactiveVariables.Count;
        ReactiveVariables.Add(this);
        _jsName = $"_reactive{_id}";
        Component.JsCache += $"let {_jsName} = {value};";
    }
}
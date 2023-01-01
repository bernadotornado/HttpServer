namespace HttpServer.lib;

public class Reactive<T>
{
    private T _value;
    public T Value
    {
        get => _value;
        set => _value = value;
    }

    public Reactive(T value)
    {
        Value = value;
    }
}
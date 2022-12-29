using HttpServer.lib;

namespace HttpServer.client.components;

public class Button : Component
{
    private Reactive<int> count = new (0);
    public override string Render()
    {
        return $"""
                <div> current count: {count.Value}</div>
                <button onclick="{Window.Alert(count.Value++)}">Click me</button> 
                """;
    }

   

}
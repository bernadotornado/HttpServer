namespace HttpServer;

public class Button : Component
{
    private int count = 0;
    public override string Render()
    {
        return $"""
                <button onclick="{Window.Alert(count++)}">Click me</button> 
                """;
    }

   

}
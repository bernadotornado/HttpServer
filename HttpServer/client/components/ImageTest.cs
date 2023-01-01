using HttpServer.lib;

namespace HttpServer.client.components;

public class ImageTest : Component
{
    public override string Render()
    {
        return $"""
                <img src="{new Image(Image.ImageFormat.PNG, Root.ClientDirectory+"assets/images/testimg.png")}">
                """;
    }
}
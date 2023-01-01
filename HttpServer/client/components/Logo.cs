using HttpServer.lib;

namespace HttpServer.client.components;

public class Logo : Component
{
    public override string Render()
    {
        return $"""
                <div class="flex items-center justify-center mt-10 mb-10">
                    <img src="{new Image(Image.ImageFormat.PNG, Config.ClientDirectory+"assets/images/logo-big-white.png")}" alt="Logo Big White" class="w-64 h-64 rounded-full">
                </div>
                """;
    }
}
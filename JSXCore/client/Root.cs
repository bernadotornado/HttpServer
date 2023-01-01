using System.IO;
using HttpServer.client.components;
using HttpServer.lib;

namespace HttpServer.client;

public class Root: Component
{
    private string customStyle = File.ReadAllText(Config.ClientDirectory+"style/style.css");
    private string tailwind = """ 
                        <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">
                        """;

   
    
    public override string Render()
    {
        return $"""
                <!DOCTYPE html>
                <html lang="en">
                    <head>
                        <title>Landing Page</title>
                        <link rel="icon" type="image/x-icon" href="{new Image(Image.ImageFormat.FAVICON, Config.ClientDirectory+"assets/favicon/favicon.ico")}">
                        {(Config.UseCustomCss ? 
                            $"<style>{customStyle}</style>" : tailwind)}
                    </head> 
                    <body class="bg-gray-800 text-gray-200">
                        {new App()}
                        {new JSImport()}
                    </body>
                </html>
                """;
    }

}


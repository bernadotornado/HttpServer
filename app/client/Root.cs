using System.IO;
using JSXCore;
using app.client.components;

namespace app.client;

public class Root: Component
{
    private readonly string _customStyle = File.ReadAllText(Config.ClientDirectory + "assets/style/style.css");
    private readonly string _tailwind = 
        """ 
        <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">
        """;
    public override string Render() => 
        $"""
        <!DOCTYPE html>
        <html lang="en">
            <head>
                <title>{Config.AppName}</title>
                <link rel="icon" type="image/x-icon" 
                href="{new Image(ImageFormat.Favicon, Config.ClientDirectory+"assets/images/favicon/favicon.ico")}">
                {(Config.UseCustomCss ? 
                    $"<style>{_customStyle}</style>" : _tailwind)}
            </head> 
            <body class="bg-gray-800 text-gray-200">
                {new App()}
                {new JsImport()}
            </body>
        </html>
        """;
}


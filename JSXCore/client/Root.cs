using System.IO;
using JSXCore.client.components;
using JSXCore.lib;
using JSXCore.server;

namespace JSXCore.client;

public class Root: Component
{
    private string _customStyle = File.ReadAllText(Config.ClientDirectory+"assets/style/style.css");
    private string _tailwind = 
        """ 
        <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">
        """;
    public override string Render() => 
        $"""
        <!DOCTYPE html>
        <html lang="en">
            <head>
                <title>JSXCore Hello, world!</title>
                <link rel="icon" type="image/x-icon" 
                href="{new Image(ImageFormat.FAVICON, Config.ClientDirectory+"assets/images/favicon/favicon.ico")}">
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


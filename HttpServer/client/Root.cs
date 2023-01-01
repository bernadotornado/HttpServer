using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HttpServer.client.components;
using HttpServer.lib;

namespace HttpServer.client
{
    public class Root: Component
    {
        private string customStyle = File.ReadAllText(Root.ClientDirectory+"style/style.css");

        private string tailwind = """ 
                            <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">
                            """;

        public static readonly string ClientDirectory = "../../../client/";
        
        public override string Render()
        {
            return $"""
                    <!DOCTYPE html>
                    <html ""lang = en"">
                        <head>
                            <title>Landing Page</title>
                            <link rel="icon" type="image/x-icon" href="{new Image(Image.ImageFormat.FAVICON, Root.ClientDirectory+"assets/favicon/favicon.ico")}">
                            {(Config.UseCustomCss ? 
                                $"<style>{customStyle}</style>" : tailwind)}
                        </head> 
                        <body>
                            {new App()}
                        </body>
                    </html>
                    """;
        }

    }
}

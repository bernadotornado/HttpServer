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
        private string style = "";

        private string tailwind = """ 
                            <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">
                            """;
        void GetStyle()
        {
            var stylesheet = File.ReadAllLines(@"../../../client/style/style.css");
            foreach (var line in stylesheet)
                style += line;
            
        }

        public Root()
        {
            GetStyle();
        }
        
        public override string Render()
        {
            return $"""
                    <!DOCTYPE html>
                    <html ""lang = en"">
                        <head>
                            <title>Landing Page</title>
                            {(Config.customcss ? 
                                $"<style>{style}</style>" : tailwind)}
                            
                        </head> 
                        <body>
                            {new App()}
                        </body>
                    </html>
                    """;
        }

    }
}

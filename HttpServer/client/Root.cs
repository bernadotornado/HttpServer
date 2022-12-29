using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer.client
{
    public class Root: Component
    {
        private string style = "";
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
                            <style>
                              {style}  
                            </style>
                        </head> 
                        <body>
                            {new App()}
                        </body>
                    </html>
                    """;
        }

    }
}

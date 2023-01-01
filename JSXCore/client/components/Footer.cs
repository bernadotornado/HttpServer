using System.Collections.Generic;
using JSXCore.lib;
using JSXCore.server;

namespace HttpServer.client.components;

public class Footer: Component
{
  public override string Render()
  {
    var logos = new Dictionary<string, string>() { 
      {"github-logo", "https://github.com/bernadotornado/HttpServer" },
      {"twitter-logo", ""},
      {"google-logo",""},
      {"instagram-logo",""},
      {"linkedin-logo",""} 
    };

  var content = "";
    foreach (var logo in logos)
      content += $"""
                  <a href="{logo.Value}" class="mr-6 text-gray-600">
                    {new Image(Image.ImageFormat.SVG, 
                      Config.ClientDirectory+"assets/images/social-networks/"+logo.Key+".svg")}
                  </a>                      
                  """ ;
    return $""" 
              <footer class="mb-0 text-center bg-gray-900 text-white flex items-center justify-center">
                <div class="flex justify-center items-center lg:justify-between p-6 border-b border-gray-300">
                  <div class="flex justify-center">
                    {content}
                  </div>
                </div>
              </footer>
            """;
  }
}
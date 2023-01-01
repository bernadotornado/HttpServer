using System.IO;
using HttpServer.lib;

namespace HttpServer.client.components;

public class JSImport: Component
{
    public override string Render()
    {
        return $"""
                <script lang="javascript">
                    {File.ReadAllText(Config.ClientDirectory+"/assets/scripts/button.js")}
                </script>
                """ ;
    }
}
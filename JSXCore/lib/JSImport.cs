using System.IO;

namespace JSXCore.lib;

public class JsImport: Component
{
    private string _path = null;
    public JsImport(string path = null) => _path = path;
        
    public override string Render()  =>
        $"""
         <script lang="javascript">
             { (_path != null ? 
                 File.ReadAllText(_path) :
                 JsCache)}
         </script>
         """ ;
        
    
}
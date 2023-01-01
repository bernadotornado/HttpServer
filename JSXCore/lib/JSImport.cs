using System.IO;

namespace JSXCore.lib;

public class JSImport: Component
{
    private string path = null;
    public JSImport(string path = null) => this.path = path;
        
    public override string Render()  =>
        $"""
         <script lang="javascript">
             { (path != null ? 
                 File.ReadAllText(path) :
                 jsCache)}
         </script>
         """ ;
        
    
}
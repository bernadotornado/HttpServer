using System.Collections.Generic;
using JSXCore;

namespace app.client.components;

public class Table : Component
{
    Dictionary<string, string> _words = new ()
    {
        { "Lorem", "A filler word meaning 'dummy text'" },
        { "Ipsum", "Another filler word meaning 'dummy text'" },
        { "Dolor", "A Latin word meaning 'pain' or 'sorrow'" },
        { "Sit", "A verb meaning 'to be in a certain place'" },
        { "Amet", "A Latin word meaning 'love' or 'like'" }
    };

    string GenerateTableContent()
    {   string content = "";
        foreach (var pair in _words)
            content += $"""
                        <tr>
                            <td class="border px-4 py-2">{pair.Key}</td>
                            <td class="border px-4 py-2">{pair.Value}</td>
                        </tr>
                        """; 
        return content;
    }
    
    public override string Render() => 
        $"""
        <div class="mb-5 flex items-center justify-center">
        <table class="table-auto rounded-lg bg-gray-700 shadow-md">
            <thead class="text-lg font-bold">
              <tr>
                <th class="px-4 py-2">Word</th>
                <th class="px-4 py-2">Definition</th>
              </tr> 
            </thead>  
            <tbody>
                {GenerateTableContent()}
            </tbody>
        </table>
        </div>
        """;
}
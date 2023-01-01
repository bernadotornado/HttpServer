using System;
using HttpServer.lib;

namespace HttpServer.client.components;

public class Date : Component
{
    public override string Render()
    {
        return $""" 
                <h4 class="text-2xl font-bold text-white-800 mb-4 flex items-center justify-center">The Current Date is: {DateTime.Now}</h4>
                """;
    }
}
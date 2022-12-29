using System;
using HttpServer.lib;

namespace HttpServer.client.components;

public class Date : Component
{
    public override string Render()
    {
        return $""" 
                <div>The Current Date is: {DateTime.Now.Date}</div>
                """;
    }
}
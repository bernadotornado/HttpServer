using System;

namespace HttpServer;

public class Date : Component
{
    public override string Render()
    {
        return $""" 
                <div>The Current Date is: {DateTime.Now.Date}</div>
                """;
    }
}
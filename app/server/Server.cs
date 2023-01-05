using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using app.client;
using app.server.requests;

namespace app.server;

static class Server
{
    static void Main()
    {
        HttpListener listener = new ();
        listener.Prefixes.Add(Config.HostUrl);
        listener.Start();
        Console.WriteLine($"Listening for requests on {Config.HostUrl}");
        
        while (true)
        {
            var context = listener.GetContext();
            var request = context.Request;
            
            switch (request.HttpMethod)
            {
                case "POST" : new POST().Handle(request); break;
                case "GET" : new GET().Handle(context); break;
            }
        }
    }
}


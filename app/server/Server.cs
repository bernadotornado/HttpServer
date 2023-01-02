using System;
using System.Net;
using app.client;

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
            HttpListenerResponse response = listener.GetContext().Response;

            string responseString = new Root().Render();
            
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;

            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}


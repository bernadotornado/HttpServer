using System;
using System.Net;
using System.Collections.Generic;

using HttpServer.client;

namespace HttpServer
{
    class Server
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();
            Console.WriteLine("Listening for requests...");

            while (true)
            {
                // Wait for a request
                HttpListenerContext context = listener.GetContext();

                // Obtain a response object
                HttpListenerResponse response = context.Response;

                // Construct a response
                var root = new Root();
                string responseString = root.Render();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;

                // Get a response stream and write the response to it
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);

                // You must close the output stream.
                output.Close();
            }
        }
    }
}

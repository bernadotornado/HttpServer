using System.Net;
using app.client;

namespace app.server.requests;

public class GET
{
    public void Handle(HttpListenerContext context)
    {
        HttpListenerResponse response = context.Response;
        string responseString = new Root().Render();
        
        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
        response.ContentLength64 = buffer.Length;
        System.IO.Stream output = response.OutputStream;
        
        output.Write(buffer, 0, buffer.Length);
        output.Close();
    }
}
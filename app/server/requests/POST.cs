using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;

namespace app.server.requests;

public class POST
{
    sealed record Element(
        string innerHTML,
        string innerText);

    public void Handle(HttpListenerRequest request)
    {
        StreamReader sr = new StreamReader(request.InputStream);
        var a= sr.ReadToEnd();
        Console.WriteLine(a);
        var x =  JsonDocument.Parse(a);
        var c = x.Deserialize<Element>();
        Console.WriteLine(c.innerText);
        Console.WriteLine(c.innerHTML);
        sr.Close();
    }
    
}
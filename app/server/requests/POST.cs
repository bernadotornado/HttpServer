using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;

namespace app.server.requests;

public class POST
{
    sealed record Person(
        string name,
        int age);

    public void Handle(HttpListenerRequest request)
    {
        StreamReader sr = new StreamReader(request.InputStream);
        var a= sr.ReadToEnd();
        var x =  JsonDocument.Parse(a);
        var c = x.Deserialize<Person>();
        Console.WriteLine(c?.age);
        Console.WriteLine(c?.name);
        Console.WriteLine(a);
        sr.Close();
    }
    
}
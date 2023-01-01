using System;
using System.IO;
using System.Linq;
using System.Net;
using HttpServer.client;

namespace HttpServer.lib;

public class Image
{
    public enum ImageFormat
    {
        JPEG,
        PNG,
        SVG,
        FAVICON
    }
    private string path;
    private string dataHeader = "";
    public Image(ImageFormat format,  string path)
    {
        switch (format)
        {
            case ImageFormat.JPEG: dataHeader += "data:image/jpeg;base64,"; break;
            case ImageFormat.PNG: dataHeader += "data:image/png;base64,"; break;
            case ImageFormat.SVG: dataHeader += "data:image/svg;base64,"; break;
            case ImageFormat.FAVICON: dataHeader += "data:image/x-icon;base64,"; break;
        }
        this.path = path;
    }

    

    public override string ToString()
    {
        return dataHeader + 
               Convert.ToBase64String(File.ReadAllBytes(path));
    }
}
using System;
using System.IO;
using System.Linq;
using System.Net;
using HttpServer.client;

namespace HttpServer.lib;

public class Image
{
    private ImageFormat _format;
    public enum ImageFormat
    {
        JPEG,
        PNG,
        SVG,
        FAVICON
    }
    private string _path;
    private string dataHeader = "";
    public Image(ImageFormat format,  string path)
    {
        switch (format)
        {
            case ImageFormat.JPEG: dataHeader += "data:image/jpeg;base64,"; break;
            case ImageFormat.PNG: dataHeader += "data:image/png;base64,"; break;
            case ImageFormat.FAVICON: dataHeader += "data:image/x-icon;base64,"; break;
        }
        this._path = path;
        this._format = format;
    }

    public override string ToString()
    => _format == ImageFormat.SVG? 
        File.ReadAllText(_path) :
        dataHeader + Convert.ToBase64String(File.ReadAllBytes(_path));
}
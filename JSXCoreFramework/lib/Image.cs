using System;
using System.IO;

namespace JSXCore.lib;

public enum ImageFormat
{
    JPEG,
    PNG,
    SVG,
    FAVICON
}
public class Image
{
    
    
    private ImageFormat _format;
    private string _path;
    private string _dataHeader = "";
    public Image(ImageFormat format,  string path)
    {
        _dataHeader += "data:image/" + format switch
        {
            ImageFormat.JPEG => "jpeg;base64,",
            ImageFormat.PNG => "png;base64,",
            ImageFormat.FAVICON => "x-icon;base64,",
            ImageFormat.SVG => ""
        };
        _path = path;
        _format = format;
    }

    public override string ToString()
    => _format == ImageFormat.SVG? 
        File.ReadAllText(_path) :
        _dataHeader + Convert.ToBase64String(File.ReadAllBytes(_path));
}
namespace JSXCore;

public enum ImageFormat
{
    Jpeg,
    Png,
    Svg,
    Favicon
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
            ImageFormat.Jpeg => "jpeg;base64,",
            ImageFormat.Png => "png;base64,",
            ImageFormat.Favicon => "x-icon;base64,",
            ImageFormat.Svg => "",
            _ => ""
        };
        _path = path;
        _format = format;
    }

    public override string ToString()
    => _format == ImageFormat.Svg? 
        File.ReadAllText(_path) :
        _dataHeader + Convert.ToBase64String(File.ReadAllBytes(_path));
}
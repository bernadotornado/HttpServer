namespace JSXCore.lib;

public static class Document
{
    public static Element GetElementById(string id)
    {
        return new Element(id);
    }
}
namespace JSXCore;

public class Element
{
    public string id;
    public Element(string id)=> this.id = id;
    public string InnerHTML() => $"document.getElementById('{id}').innerHTML";
}
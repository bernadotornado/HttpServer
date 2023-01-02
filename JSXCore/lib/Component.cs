using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace JSXCore;
public class Component
{
    public static string JsCache = "";
    private BigInteger _id;
    private static List<Component> _componentRegistry = new ();
    public virtual string Render()=> "";
    public override string ToString()
    {
        _id = _componentRegistry.Count;
        _componentRegistry.Add(this);
        var componentName = GetType().ToString().Split(".").Last();
        string Decorator(string s) => $"<!--@{s} {componentName} | id: {_id}-->";
        
        return Decorator("begin") +
               Render() + 
               Decorator("end");
    }
}

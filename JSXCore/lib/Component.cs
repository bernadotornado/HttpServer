using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace JSXCore.lib
{
    public class Component
    {
        
        public static string jsCache = "";
        private BigInteger id;
        private static List<Component> componentTree = new ();
        public virtual string Render()=>  "";
        public override string ToString()
        {
            Random r = new Random();
            id = componentTree.Count;
            componentTree.Add(this);
            
            return $"<!--@begin {this.GetType().ToString().Split(".").Last()} | id: {id}-->" +
                   Render() + 
                   $"<!--@end {this.GetType().ToString().Split(".").Last()} | id: {id}-->";
        }
    }
}

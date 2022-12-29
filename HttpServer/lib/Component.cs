using System;
using System.Collections.Generic;
using System.Linq;

namespace HttpServer.lib
{
    public class Component
    {
        private int id;
        private static List<Component> componentTree = new ();
        public virtual string Render()
        {
            return "";
        }
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

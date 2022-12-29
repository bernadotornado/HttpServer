using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    public class Component
    {
        public virtual string Render()
        {
            return "";
        }
        public override string ToString()
        {
            return Render();
        }
    }
}

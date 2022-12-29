using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    class App : Component
    {
        public override string Render()
        {
            return $""" 
                    <h1> Hello, world! </h1> 
                    <p> This is a test of the new blazingly fast framework. </p>
                    {new Date()}  
                    {new Button()}
                    """;
        }
    }
}

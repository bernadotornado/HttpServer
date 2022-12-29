using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    static class Window
    {
        public static string Alert(object s) => $"window.alert(\'{s}\')";
    }
}

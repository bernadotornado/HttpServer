namespace HttpServer.lib
{
    static class Window
    {
        public static string Alert(object s) => $"window.alert(\'{s}\')";
    }
}

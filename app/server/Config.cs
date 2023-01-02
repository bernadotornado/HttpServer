namespace app.server;

public static class Config
{
    public static readonly string ClientDirectory = System.AppContext.BaseDirectory + "../../../client/";
    public static string HostUrl = "http://localhost:8081/";
    public static bool UseCustomCss = false;
}
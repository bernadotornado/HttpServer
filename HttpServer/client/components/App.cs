using HttpServer.lib;

namespace HttpServer.client.components
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
                    {new TailwindTest()}
                    {new ImageTest()}
                    """;
        }
    }
}

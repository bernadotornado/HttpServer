using JSXCore.lib;

namespace JSXCore.client.components
{
    class App : Component
    {
        public override string Render()
        {
            return $""" 
                    {new Logo()}
                    <h1 class="text-slate-900 text-4xl tracking-tight font-bold sm:text-5xl dark:text-white flex items-center justify-center mb-5">Hello, world!</h1>
                    <h2 class="text-4xl font-bold text-white-800 mb-4 flex items-center justify-center">This is a test of the new blazingly fast framework.</h2>
                    {new Date()}  
                    {new Button()}
                    {new Table()}
                    {new Footer()}
                    """;
        }
    }
}

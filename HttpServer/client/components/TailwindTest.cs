using HttpServer.lib;

namespace HttpServer.client.components;

public class TailwindTest : Component
{
    public override string Render()
    {
        return """ 
                <div class="flex items-center">
                <div class="hidden md:block">
                <div class="ml-10 flex items-baseline">
                    <a href="#" class="px-3 py-2 rounded-md text-sm font-medium text-white bg-gray-900 focus:outline-none focus:text-white focus:bg-gray-700">Home</a>
                    <a href="#" class="ml-4 px-3 py-2 rounded-md text-sm font-medium text-gray-300 hover:text-white hover:bg-gray-700 focus:outline-none focus:text-white focus:bg-gray-700">About</a>
                    <a href="#" class="ml-4 px-3 py-2 rounded-md text-sm font-medium text-gray-300 hover:text-white hover:bg-gray-700 focus:outline-none focus:text-white focus:bg-gray-700">Contact</a>
                </div>
                </div>
                </div>
                """;
    }
}
using JSXCore;

namespace app.client.components;

public class Button : Component
{
    private Reactive<int> _count = new (1);
    public override string Render()
    {
        string handleButtonClick = 
            $"""
            {Document.GetElementById("counter-btn").InnerHTML()} = 'Clicked '+ {_count}++ +' times!';
            """;
        return $"""
                <div id="counter-btn" class="flex items-center justify-center" >Clicked 0 times!</div>
                <div class="flex space-x-2 justify-center">
                    <button class="mt-5 mb-5 inline-block px-6 py-2.5 bg-blue-600 text-white font-medium text-xs 
                    leading-tight uppercase rounded shadow-md hover:bg-gray-900 hover:shadow-lg focus:bg-gray-900 
                    focus:shadow-lg focus:outline-none focus:ring-0 active:bg-gray-900 active:shadow-lg transition 
                    duration-150 ease-in-out"
                    onclick="{handleButtonClick}">
                        Click me
                    </button> 
                </div>
                """;
    }   
}
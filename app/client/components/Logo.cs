﻿using JSXCore;

namespace app.client.components;

public class Logo : Component
{
    public override string Render()=>
        $"""
        <div class="flex items-center justify-center mt-10 mb-10">
            <img src="{new Image(ImageFormat.Png,
                Config.ClientDirectory+"assets/images/favicon/logo-big-white.png")}" 
                alt="Logo Big White" 
                class="w-64 h-64 rounded-full">
        </div>
        """;
}
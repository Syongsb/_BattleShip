
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

namespace GameLogic
{
    public class GameLogic
    {

        public static void Main()
        {
            // Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

            // Load Resources
            GameResources.LoadResources();

            SwinGame.PlayMusic(GameResources.GameMusic("Background"));

            do
            {
                GameController.HandleUserInput();
                GameController.DrawScreen();
                if (SwinGame.KeyTyped(KeyCode.vk_b))
                {
                    SwinGame.StopMusic();
                }
            }
            // Game Loop
            while (!(SwinGame.WindowCloseRequested() == true || GameController.CurrentState == GameState.Quitting));

            SwinGame.StopMusic();

            // Free Resources and Close Audio, to end the program.
            GameResources.FreeResources();
        }
    }
}

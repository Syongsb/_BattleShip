
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

            SwinGame.PlayMusic(GameResources.GameMusic("Silent"));

            do
            {
                GameController.HandleUserInput();
                GameController.DrawScreen();
                if (SwinGame.KeyTyped(KeyCode.vk_b))
                {
					if (SwinGame.MusicPlaying ()) {
						SwinGame.StopMusic ();
					} else { 
						SwinGame.PlayMusic (GameResources.GameMusic ("Silent"));
					}
                }

				if (SwinGame.KeyTyped (KeyCode.vk_1)) {
					SwinGame.PlayMusic (GameResources.GameMusic ("Mario1"));
				} else if (SwinGame.KeyTyped (KeyCode.vk_2)) {
					SwinGame.PlayMusic (GameResources.GameMusic ("Mario2"));
				} else if (SwinGame.KeyTyped (KeyCode.vk_3)) {
					SwinGame.PlayMusic (GameResources.GameMusic ("Mario3"));
				} else if (SwinGame.KeyTyped (KeyCode.vk_4)) {
					SwinGame.PlayMusic (GameResources.GameMusic ("Silent"));
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

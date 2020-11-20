using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;

namespace PSReader
{
	public class AppMain
	{
		private static GraphicsContext graphics;
		
		public static void Main (string[] args)
		{
			Initialize ();

			while (true) {
				SystemEvents.CheckEvents ();
				Update ();
				Render ();
			}
		}

		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
			
			UISystem.Initialize(graphics);
			
			var MainScreen = new PSReader.MainScreen();
			UISystem.SetScene(MainScreen);
		}

		public static void Update ()
		{
			// Query gamepad for current state
			var gamePadData = GamePad.GetData (0);
			
			// Query touch for current state
            List<TouchData> touchDataList = Touch.GetData (0);

            // Update UI Toolkit
            UISystem.Update(touchDataList);
		}

		public static void Render ()
		{
			// Clear the screen
			graphics.SetClearColor (255, 255, 255, 255);
			graphics.Clear ();
            UISystem.Render ();

			// Present the screen
			graphics.SwapBuffers ();
		}
	}
}

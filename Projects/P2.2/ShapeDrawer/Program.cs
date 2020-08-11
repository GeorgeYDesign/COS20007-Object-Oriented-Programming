using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Shape myshape = new Shape();

            new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myshape.Draw();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myshape.X = SplashKit.MouseX();
                    myshape.Y = SplashKit.MouseY();
                    myshape.color = SplashKit.ColorGreen();

                }

                if (myshape.IsAt(SplashKit.MousePosition()))
                {
                    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                    {
                        myshape.color = SplashKit.RandomColor();
                    }
                }

                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}
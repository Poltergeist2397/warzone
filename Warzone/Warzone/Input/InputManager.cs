using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input;

namespace Warzone.Input
{
    public delegate void InputHandler(object sender, EventArgs e);

    public class InputManager 
    {
        public static event InputHandler InputUpdate;

        static bool leftClicked;
        bool rightClicked;

        private static InputState Input = new InputState();

        static IList<Keys> numberKeys = new List<Keys>();

        public static void Update()
        {
            KeyboardState keybState = Keyboard.GetState();
            Vector2 preMousePos;
            //Vector2 mousePos;
            //Vector2 temp;
            //Matrix m = adapter.getCam().transform;
            //Matrix i = Matrix.Invert(m);

            preMousePos.X = Mouse.GetState().X;
            preMousePos.Y = Mouse.GetState().Y;

            //mousePos = Vector2.Transform(preMousePos, i);

            handleNumKeys(preMousePos);

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                if (!leftClicked)
                {
                    leftClicked = true;
                }
            }
            else
            {
                if (leftClicked)
                {
                    leftClicked = false;
                }
            }

        }

        static void handleNumKeys(Vector2 mousePos)
        {
            KeyboardState keybState = Keyboard.GetState();
            int id = -1;

            if (keybState.IsKeyDown(Keys.D0))
            {
                id = numberKeys.IndexOf(Keys.D0);
            }
            else if (keybState.IsKeyDown(Keys.D1))
            {
                id = numberKeys.IndexOf(Keys.D1);
            }
            else if (keybState.IsKeyDown(Keys.D2))
            {
                id = numberKeys.IndexOf(Keys.D2);
            }
            else if (keybState.IsKeyDown(Keys.D3))
            {
                id = numberKeys.IndexOf(Keys.D3);
            }
            else if (keybState.IsKeyDown(Keys.D4))
            {
                id = numberKeys.IndexOf(Keys.D4);
            }
            else if (keybState.IsKeyDown(Keys.D5))
            {
                id = numberKeys.IndexOf(Keys.D5);
            }
            else if (keybState.IsKeyDown(Keys.D6))
            {
                id = numberKeys.IndexOf(Keys.D6);
            }
            else if (keybState.IsKeyDown(Keys.D7))
            {
                id = numberKeys.IndexOf(Keys.D7);
            }
            else if (keybState.IsKeyDown(Keys.D8))
            {
                id = numberKeys.IndexOf(Keys.D8);
            }
            else if (keybState.IsKeyDown(Keys.D9))
            {
                id = numberKeys.IndexOf(Keys.D9);
            }
        }
    }
}

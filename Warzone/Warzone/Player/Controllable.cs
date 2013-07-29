using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Warzone.Entities;

namespace Warzone.Player
{
    [Flags]
    public enum Moving
    {
        None = 0, 
        Up = 1, 
        Down = 2, 
        Left = 4,
        Right = 8
    }

    public abstract class Controllable : Drawable
    {   
        public void HandleInput()
        {
            Moving moveDir = Moving.None;
            KeyboardState keybState = Keyboard.GetState();

            if (keybState.IsKeyDown(Keys.W))
                moveDir |= Moving.Up;
            if (keybState.IsKeyDown(Keys.S))
                moveDir |= Moving.Down;
            if (keybState.IsKeyDown(Keys.A))
                moveDir |= Moving.Left;
            if (keybState.IsKeyDown(Keys.D))
                moveDir |= Moving.Right;

            MovementUpdate(moveDir);
        }

        public abstract void MovementUpdate(Moving directions);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace Warzone.Input
{
    public class InputState
    {
        public HashSet<Keys> Pressed;
        public HashSet<Keys> Held;
        public HashSet<Keys> Released;

        public InputState()
        {
            Pressed = new HashSet<Keys>();
            Held = new HashSet<Keys>();
            Released = new HashSet<Keys>();
        }

        public void Clear()
        {
            Pressed.Clear();
            Held.Clear();
            Released.Clear();
        }
    }
}

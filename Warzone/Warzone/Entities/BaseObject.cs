using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Warzone.Entities
{
    public abstract class BaseObject
    {
        public Vector2 Position = new Vector2(0, 0);

        public abstract void Update(GameTime gt);
    }
}

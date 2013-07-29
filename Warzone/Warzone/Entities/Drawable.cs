using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Warzone.Entities
{
    public abstract class Drawable : BaseObject
    {
        public Texture2D myTexture;
        public float textureRotation = 0;
        public Color myColor = Color.White;

        public void Draw(SpriteBatch sBatch)
        {
            if (myTexture != null)
            {
                sBatch.Draw(myTexture, Position, null, myColor, textureRotation, new Vector2(myTexture.Width / 2, myTexture.Height / 2), 1f, SpriteEffects.None, .5f);
            }
        }
    }
}

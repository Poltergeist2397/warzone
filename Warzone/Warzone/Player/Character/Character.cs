using System;
using Warzone.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Warzone.Entities;

namespace Warzone.Player.Character
{
    public class Character : BaseObject
    {

        private Bottom bottomPart;
        private Top topPart;

        public Character(Vector2 startPos)
        {
            this.Position = startPos;

            bottomPart = new Bottom(this);
            bottomPart.Position = Position;

            topPart = new Top();
            topPart.Position = Position;
        }

        public override void Update(GameTime gameTime)
        {
            bottomPart.Update(gameTime);
            topPart.Update(gameTime);
            this.Position = bottomPart.Position;
            topPart.Position = this.Position;
        }

        public void Draw(SpriteBatch sBatch)
        {
            bottomPart.Draw(sBatch);
            topPart.Draw(sBatch);
        }
    }
}

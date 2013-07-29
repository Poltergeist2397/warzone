using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warzone.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Warzone.Graphics;

namespace Warzone.Player.Character
{
    public class Top : Drawable
    {

        private float turnSpeed = 90;

        private float rotation;

        public Top()
        {
            myTexture = TextureManager.GetTexture("Arrow");
            myColor = Color.Red;

            rotation = 0;
        }

        public override void Update(GameTime gt)
        {
            Vector2 mousePos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            float desired = (float)Math.Atan2(mousePos.Y - this.Position.Y, mousePos.X - this.Position.X) + (float)(Math.PI / 2);

            if ((Position.X - mousePos.X) * Math.Sin(rotation) > (Position.Y - mousePos.Y) * Math.Cos(rotation))
            {
                rotation += turnSpeed * (float)Math.PI / 180 * gt.ElapsedGameTime.Milliseconds / 1000;
            }
            else
            {
                rotation -= turnSpeed * (float)Math.PI / 180 * gt.ElapsedGameTime.Milliseconds / 1000;
            }

            if (Math.Abs(desired - rotation) < Math.PI / 36)
                rotation = desired;

            this.textureRotation = rotation + (float)(Math.PI / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warzone.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Warzone.Graphics;

namespace Warzone.Player.Character
{
    public class Bottom : Controllable
    {

        private Character myCharacter;

        float direction;

        int turnDirection;

        private float _turnSpeed;
        /// <summary>
        /// Turn speed for this base; expressed in degrees/sec
        /// </summary>
        public float TurnSpeed
        {
            get { return _turnSpeed; }
            set
            {
                if (value < 0)
                    _turnSpeed = -value;
                else
                    _turnSpeed = value;
            }

        }

        int moveDirection;
        private float _moveSpeed;
        public float MoveSpeed
        {
            get { return _moveSpeed; }
            set { _moveSpeed = value; }
        }

        public Bottom(Character c)
        {
            myTexture = TextureManager.GetTexture("Arrow");
            myCharacter = c;

            direction = 0;
            turnDirection = 0;
            _turnSpeed = 135;
            moveDirection = 0;
            _moveSpeed = 60;

        }

        public override void Update(GameTime gt)
        {
            HandleInput();

            float tsRad;

            if (turnDirection != 0)
            {
                // Convert turnspeed to radians
                tsRad = _turnSpeed / 180f * (float)Math.PI;
                direction += turnDirection * tsRad * gt.ElapsedGameTime.Milliseconds / 1000;
            }

            if (moveDirection != 0)
            {
                float actualDir = direction - (float)(Math.PI / 2);
                this.Position.X += moveDirection * (float)Math.Cos(actualDir) * _moveSpeed * gt.ElapsedGameTime.Milliseconds / 1000;
                this.Position.Y += moveDirection * (float)Math.Sin(actualDir) * _moveSpeed * gt.ElapsedGameTime.Milliseconds / 1000;
            }

            if (direction < 0) direction += (float)(2 * Math.PI);
            if (direction > (2 * Math.PI)) direction -= (float)(2 * Math.PI);
            textureRotation = direction;
        }

        #region Movement

        public override void MovementUpdate(Moving directions)
        {
            int finaldir = 0;

            if ((directions & Moving.Left) == Moving.Left)
                finaldir -= 1;
            if ((directions & Moving.Right) == Moving.Right)
                finaldir += 1;

            turnDirection = finaldir;
            finaldir = 0;

            if ((directions & Moving.Up) == Moving.Up)
                finaldir += 1;
            if ((directions & Moving.Down) == Moving.Down)
                finaldir -= 1;
            moveDirection = finaldir;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MyGame
{
    public class Ball : CollisionObject
    {
        public Vector2 velocity;
        private bool flag;

        public Ball()
        {
            sprite = Sprites.ball;
            CalculateOrigin();
            bounds.Size = new Point(20, 20);
            Reset();
            
        }

        public override void Update(GameTime time)
        {
            if (position.X < -20 || position.X > 820) Reset();
            if ((CheckCollisions(Entities.player) || CheckCollisions(Entities.enemy)) && !flag) // if we are colliding with a paddle and this is the first frame we have collided with one
            {
                velocity.X *= -1.3f; // bounce and increase ball speed by 30%
                if (Math.Abs(velocity.X) > 1300)
                {
                    velocity.X = Math.Sign(velocity.X) * 1300; // limit speed 
                }
                else Entities.enemy.speed *= 1.3f;
                flag = true; // we can only collide with paddle once
            }
            if (!(CheckCollisions(Entities.player) || CheckCollisions(Entities.enemy))) flag = false;
                
            if (position.Y >= 480 || position.Y <= 0) velocity.Y *= -1; // bounce off edges of screen
            position += velocity * (float)time.ElapsedGameTime.TotalSeconds; // move according to velocity frame-rate independently
            UpdateBounds(); // update collision shape
        }

        public void Reset()
        {
            position = new Vector2(390, 240);
            velocity.X = 300;
            velocity.Y = -300;
            Entities.enemy.speed = 4;
            UpdateBounds();
        }

        public Vector2 GetPos() { return position; }
    }
}

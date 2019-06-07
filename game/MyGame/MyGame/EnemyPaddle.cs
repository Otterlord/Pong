using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class EnemyPaddle : Paddle
    {
        private Random random;
        public float speed = 4;
        public EnemyPaddle()
        {
            random = new Random();
            position.X = 20;
            position.Y = 240;
            Init();
        }

        public override void Update(GameTime time)
        {
            
            if (Entities.ball.velocity.X < 0) position.Y += speed * (float)time.ElapsedGameTime.TotalSeconds * (Entities.ball.GetPos().Y - position.Y);
            else position.Y += speed * (float)time.ElapsedGameTime.TotalSeconds * (240 - position.Y);
            UpdateBounds();
        }
    }
}

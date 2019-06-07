using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MyGame
{
    public class PlayerPaddle : Paddle
    {
        public PlayerPaddle()
        {
            position.X = 780;
            Init();
        }

        public override void Update(GameTime time)
        {
            position.Y = Input.mouse.Y;
            UpdateBounds();
        }
    }
}

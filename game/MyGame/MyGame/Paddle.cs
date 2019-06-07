using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public abstract class Paddle : CollisionObject
    {
        public void Init()
        {
            this.sprite = Sprites.paddle;
            CalculateOrigin();
            bounds.Size = new Point(20, 100);
            UpdateBounds();
        }

    }
}

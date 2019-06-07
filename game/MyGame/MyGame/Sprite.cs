using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyGame
{
    public class Sprite
    {
        protected Texture2D sprite;
        protected Vector2 position;
        protected Vector2 origin;

        public void CalculateOrigin()
        {
            origin = new Vector2(sprite.Width / 2, sprite.Height / 2);
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(sprite, position - origin, Color.White);
        }
    }
}

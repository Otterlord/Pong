using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public abstract class CollisionObject : Sprite
    {
        protected Rectangle bounds;

        public string Location { get; private set; }

        public bool CheckCollisions(CollisionObject other)
        {
            Debug.WriteLine(bounds.Intersects(other.bounds));
            return bounds.Intersects(other.bounds);
        }

        public abstract void Update(GameTime time);

        public void UpdateBounds()
        {
            bounds.Location = (position - origin).ToPoint();
        }


    }
}

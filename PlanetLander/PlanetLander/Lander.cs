using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class Lander : RotatingSpriteGameObject
    {
        public Lander() : base("spr_lander")
        {
            this.origin = sprite.Center;

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.position = new Vector2(450, 150);
            this.Degrees = 270;
            this.velocity = Vector2.Zero;
        }
    }
}

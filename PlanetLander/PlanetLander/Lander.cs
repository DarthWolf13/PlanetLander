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
        }
    }
}

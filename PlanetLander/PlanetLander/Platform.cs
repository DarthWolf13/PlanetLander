using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class Platform : SpriteGameObject
    {
        public Platform() : base("spr_platform")
        {
            this.position = new Vector2(285, 535);
        }
    }
}

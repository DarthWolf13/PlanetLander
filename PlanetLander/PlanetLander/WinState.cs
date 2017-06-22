using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class WinState : GameObjectList
    {
        public WinState()
        {
            this.Add(new SpriteGameObject("spr_winscreen"));
        }
    }
}

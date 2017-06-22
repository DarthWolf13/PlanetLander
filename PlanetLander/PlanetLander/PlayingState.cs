using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class PlayingState : GameObjectList
    {
        Mountains mountains;

        public PlayingState()
        {
            mountains = new Mountains();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(mountains);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class PlayingState : GameObjectList
    {
        Mountains mountains;
        Lander lander;

        public PlayingState()
        {
            mountains = new Mountains();
            lander = new Lander();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(mountains);
            this.Add(lander);
        }
    }
}

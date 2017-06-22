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
        GameObjectList meteors;

        public PlayingState()
        {
            mountains = new Mountains();
            lander = new Lander();
            meteors = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(mountains);
            this.Add(lander);
            this.Add(meteors);

            for(int i = 0; i < 5; i++)
            {
                this.meteors.Add(new Meteor());
            }
        }
    }
}

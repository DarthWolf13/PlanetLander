using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PlanetLander
{
    class PlayingState : GameObjectList
    {
        Mountains mountains;
        Lander lander;
        GameObjectList meteors;
        public Fuel fuel;

        public PlayingState()
        {
            mountains = new Mountains();
            lander = new Lander();
            meteors = new GameObjectList();
            fuel = new Fuel();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(mountains);
            this.Add(lander);
            this.Add(meteors);
            this.Add(fuel);

            for(int i = 0; i < 5; i++)
            {
                this.meteors.Add(new Meteor());
            }

            fuel.fuelValue = 500;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Up))
            {
                fuel.fuelValue--;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if(fuel.fuelValue < 0)
            {
                fuel.fuelValue = 0;
            }

            if (lander.CollidesWith(mountains))
            {
                lander.Reset();
            }

            foreach(Meteor meteor in meteors.Objects)
            {
                if (lander.CollidesWith(meteor))
                {
                    lander.Reset();
                }
            }
        }
    }
}

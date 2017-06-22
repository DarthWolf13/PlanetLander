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
        Platform platform;

        public PlayingState()
        {
            mountains = new Mountains();
            lander = new Lander();
            meteors = new GameObjectList();
            fuel = new Fuel();
            platform = new Platform();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(mountains);
            this.Add(lander);
            this.Add(meteors);
            this.Add(fuel);
            this.Add(platform);

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
                fuel.fuelValue = 500;
            }

            foreach(Meteor meteor in meteors.Objects)
            {
                if (lander.CollidesWith(meteor))
                {
                    lander.Reset();
                    fuel.fuelValue = 500;
                }
            }

            if (lander.CollidesWith(platform) && lander.Degrees >= 260 && lander.Degrees <= 280 && lander.Velocity.Length() < 50)
            {
                PlanetLander.GameStateManager.SwitchTo("WinState");
            }
            else if (lander.CollidesWith(platform))
            {
                lander.Reset();
                fuel.fuelValue = 500;
            }
        }
    }
}

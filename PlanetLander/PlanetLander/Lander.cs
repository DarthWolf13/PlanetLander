using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class Lander : RotatingSpriteGameObject
    {
        int Fuel = 500;

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
            Fuel = 500;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Left))
            {
                this.Degrees -= 1;
            }
            if (inputHelper.IsKeyDown(Keys.Right))
            {
                this.Degrees += 1;
            }
            if (inputHelper.IsKeyDown(Keys.Up) && Fuel > 0)
            {
                this.velocity += this.AngularDirection * 2;
                Fuel--;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            this.velocity += new Vector2(0, 1);

            if(this.position.X < 0)
            {
                this.position.X = 0 + this.Width;
            }
            if (this.position.X > PlanetLander.Screen.X)
            {
                this.position.X = PlanetLander.Screen.X - this.Width;
            }
            if (this.position.Y + this.Height < 0 || this.position.Y - this.Height > PlanetLander.Screen.Y)
            {
                this.Reset();
            }
        }
    }
}

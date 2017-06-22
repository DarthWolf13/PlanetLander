using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class Meteor : SpriteGameObject
    {
        Vector2 randomPos, randomVel;

        public Meteor() : base("spr_meteor")
        {
            randomPos = new Vector2(GameEnvironment.Random.Next(0, PlanetLander.Screen.X), GameEnvironment.Random.Next(-500, -100));
            this.position = randomPos;
            randomVel = new Vector2(0, GameEnvironment.Random.Next(50, 150));
            this.velocity = randomVel;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if(this.position.Y > PlanetLander.Screen.Y)
            {
                this.position = randomPos;
            }
        }
    }
}

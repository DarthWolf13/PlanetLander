using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetLander
{
    class Fuel : TextGameObject
    {
        public int fuel;

        public Fuel(string assetname = "GameFont", int layer = 0, string id = "") : base(assetname, layer, id)
        {
            this.Text = "Fuel: 500";
            this.Position = new Vector2(0, 0);
        }

        public int fuelValue
        {
            get
            {
                return fuel;
            }

            set
            {
                fuel = value;
                this.Text = "Fuel: " + value;
            }
        }
    }
}

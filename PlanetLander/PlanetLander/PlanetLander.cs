using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PlanetLander
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class PlanetLander : GameEnvironment
    {
              
        public PlanetLander()
        {         
            Content.RootDirectory = "Content";
        }
     
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            screen.X = 800;
            screen.Y = 600;
            SetFullScreen(false);

            // TODO: use this.Content to load your game content here
            gameStateManager.AddGameState("PlayingState", new PlayingState());
            gameStateManager.AddGameState("WinState", new WinState());
            gameStateManager.SwitchTo("PlayingState");
        }      
    }
}

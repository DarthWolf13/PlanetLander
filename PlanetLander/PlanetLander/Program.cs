using System;

namespace PlanetLander
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (PlanetLander game = new PlanetLander())
            {
                game.Run();
            }
        }
    }
#endif
}


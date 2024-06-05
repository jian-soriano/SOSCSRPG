using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        // properties
        public Player CurrentPlayer {  get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        // constructor
        public GameSession()
        {
            // sets the starting player values
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jian";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            // generates the game world
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            // sets the starting location as Home
            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }
    }
}

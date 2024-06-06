using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        // FIELDS
        private Location _currentLocation;
        
        // PROPERTIES
        public Player CurrentPlayer {  get; set; }
        public Location CurrentLocation 
        { 
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                // when CurrentLocation is changed, these will update the MainWindow.xaml file appropriately
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }
        public World CurrentWorld { get; set; }
        
        // these bools will set visibility of nav buttons to Visible/Hidden if returns true/false
        public bool HasLocationToNorth
        {
            get 
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get 
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        // CONSTRUCTOR
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

        // METHODS

        // public because it will be called from the WPFUI/MainWindow.xaml.cs file
        public void MoveNorth() 
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);         
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }

        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
           CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }

    }
}

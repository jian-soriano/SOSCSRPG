using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        // fields
        private List<Location> _locations = new List<Location>();

        //methods
        // internal because WorldFactory class is the only other class that should use it
        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName) 
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);
        }

        // returns a Location from _locations with the given x/y coordinates, or null if not found
        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate) { return loc; }
            }
            return null;
        }
    }
}

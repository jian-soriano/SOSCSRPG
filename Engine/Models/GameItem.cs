using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        // PROPERTIES

        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        // CONSTRUCTOR
        
        public GameItem(int itemTypeID, string name, int price)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
        }

        // METHODS

        public virtual GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }
    }
}

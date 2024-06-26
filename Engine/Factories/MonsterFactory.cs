﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        // METHODS
        
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake = new Monster("Snake", 
                        "pack://application:,,,/Engine;component/Images/Monsters/Snake.png", 4, 4, 5, 1);
                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    return snake;

                case 2:
                    Monster rat = new Monster("Rat", 
                        "pack://application:,,,/Engine;component/Images/Monsters/Rat.png", 5, 5, 5, 1);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                    return rat;

                case 3:
                    Monster giantSpider = new Monster("Giant Spider", 
                        "pack://application:,,,/Engine;component/Images/Monsters/GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    return giantSpider;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        // randomly adds item to monster's inventory depending on provided percentage value
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}

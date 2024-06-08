using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    // internal because will only be used within the Engine project
    internal static class QuestFactory
    {
        // FIELDS

        private static readonly List<Quest> _quests = new List<Quest>();

        // CONSTRUCTOR

        static QuestFactory()
        {
            // Declare the items needed to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            // Create the quest
            _quests.Add(new Quest(1,
                                "Clear the herb garden",
                                "Defeat the snakes in the Herbalist's garden",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
        }

        // METHODS

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}

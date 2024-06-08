using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus
    {
        // PROPERTIES

        public Quest PlayerQuest { get; set; }
        public bool IsCompleted { get; set; }

        // CONSTRUCTOR

        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsCompleted = false;
        }
    }
}

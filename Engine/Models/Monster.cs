using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    internal class Monster : BaseNotificationClass
    {
        // FIELDS

        private int _hitPoints;

        // PROPERTIES

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            private set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold {  get; private set; }
        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        // CONSTRUCTOR

        public Monster(string name, string imageName, 
            int maximumHitPoints, int hitPoints, 
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = imageName;
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    /// <summary>
    /// Special Item than can be equipped. They can have a minimum stats value needed to equip them, and you can add
    /// EquippedEffect which will be executed when the object is equipped and unequipped, allowing to code special
    /// behaviour when the player equipped those object, like raising stats.
    /// </summary>
    internal class EquipmentItem: Item, IMyCloneable <EquipmentItem>, ICloneable
    {
        public enum EquipmentSlot
        {
            Head,
            Torso,
            Legs,
            Feet,
            Accessory
        }
        public EquipmentSlot Slot;

        public int MinimumStrength;
        public int MinimumAgility;
        public int MinimumDefense;

        public EquipmentItem(string itemName, string description, int minimumStrength, int minimumAgility, int minimumDefense) : base(itemName, description)
        {
            MinimumStrength = minimumStrength;
            MinimumAgility = minimumAgility;
            MinimumDefense = minimumDefense;
        }

        public override bool UsedBy(CharacterData user)
        {
            

            if (user.agility < MinimumAgility
                || user.strength < MinimumStrength
                || user.defense < MinimumDefense)
            {
                return false;
            }

            return true;
        }

        public override string GetDescription()
        {
            string desc = base.GetDescription();
        

            bool requireStrength = MinimumStrength > 0;
            bool requireDefense = MinimumDefense > 0;
            bool requireAgility = MinimumAgility > 0;

            if (requireStrength || requireAgility || requireDefense)
            {
                desc += "\nRequire : \n";

                if (requireStrength)
                    desc += $"Strength : {MinimumStrength}";

                if (requireAgility)
                {
                    if (requireStrength) desc += " & ";
                    desc += $"Defense : {MinimumDefense}";
                }

                if (requireDefense)
                {
                    if (requireStrength || requireAgility) desc += " & ";
                    desc += $"Agility : {MinimumAgility}";
                }
            }

            return desc;
        }

       public  EquipmentItem MyClone()
        {
            return new EquipmentItem(ItemName, Description, MinimumStrength, MinimumAgility, MinimumDefense );
        }
       public  object Clone() => MyClone();

        public override void GetInfo()
        {
            Console.WriteLine($"ItemName {ItemName} Description {Description} MinimumStrength {MinimumStrength}  MinimumAgility {MinimumAgility} MinimumDefense {MinimumDefense} ");
        }
    }


}

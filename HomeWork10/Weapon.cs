using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Weapon : EquipmentItem, IMyCloneable<Weapon>, ICloneable
    {
       
       
            public int Speed { get; set; }
          
            public int Damage { get; set; }
          

        public Weapon(string itemName, string description, int minimumStrength, int minimumAgility, int minimumDefense, int speed, int damage) : base(itemName, description, minimumStrength, minimumAgility, minimumDefense)
        {
            Speed = speed;
            Damage = damage;
        }

        public bool CanHit(CharacterData attacker, CharacterData target)
        {
            if (Vector3.Distance(attacker.position, target.position)>10)
            {

                return true;
            }

            return false;
        }
        public void Attack(CharacterData attacker, CharacterData target)
        {

          
        }
        public override string GetDescription()
        {
            string desc = base.GetDescription();

       

            return desc;
        }
       public  Weapon MyClone()
        {
            return new Weapon(ItemName, Description, MinimumStrength, MinimumAgility, MinimumDefense, Speed, Damage);
        }
        public  object Clone() => MyClone();


        public override void GetInfo()
        {
            Console.WriteLine($"ItemName {ItemName} Description {Description} MinimumStrength {MinimumStrength}" +
                $"  MinimumAgility {MinimumAgility} MinimumDefense {MinimumDefense}" +
                $"Speed {Speed} Damage {Damage}  ");
        }

      
    }
}

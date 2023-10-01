using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace HomeWork10
{
    /// <summary>
    /// Base clase of all items in the game. This is an abstract class and need to be inherited to specify behaviour.
    /// The project offer 3 type of items : UsableItem, Equipment and Weapon
    /// </summary>
    public class Item:IMyCloneable<Item>, ICloneable
    {
       
        public string? ItemName { get; set; }

        public string? Description { get; set; }

        public Item(string itemName, string description)
        {
            ItemName = itemName;
            Description = description;
        }
        /// <summary>
        /// Called by the inventory system when the object is "used" (double clicked)
        /// </summary>
        /// <returns>If it was actually used (allow the inventory to know if it can remove the object or not)</returns>

        public virtual bool UsedBy(CharacterData user)
        {
            return false;
        }

        public virtual string GetDescription()
        {
            return Description;
        }

       

      public   object Clone() => MyClone();

        public virtual void GetInfo()
        {
            Console.WriteLine($"ItemName {ItemName}   Description {Description} ");
        }

       public  Item MyClone() => new Item(ItemName, Description);
       
    }
}

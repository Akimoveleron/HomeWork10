using HomeWork10;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Item item1 = new Item("gold", "rare");
        item1.GetInfo();
        Item item2 = item1.MyClone();
        item2.GetInfo();

        EquipmentItem equipmentItem1 = new EquipmentItem("cap", "black", 5, 5, 5);
        equipmentItem1.GetInfo();
       EquipmentItem equipmentItem2 = equipmentItem1.MyClone();
        equipmentItem2.GetInfo();


        Weapon weapon1 = new Weapon("gun", "powerful", 10, 10, 10, 1, 50);
        weapon1.GetInfo();
        Weapon weapon2 = (Weapon)weapon1.MyClone();
        weapon2.GetInfo();


    }
}
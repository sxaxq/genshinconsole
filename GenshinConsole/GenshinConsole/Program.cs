using System;
using System.Collections;

namespace GenshinConsole
{
    class Bebra
    {
        static void Main(string[] args)
        {
            GameEntity entity1 = new GameEntity();
            Console.WriteLine(entity1.NumberOfCellsInventory);
            entity1.UpdateCheck(entity1);
            Console.WriteLine(entity1.NumberOfCellsInventory);
            entity1.AddItemInventory(new FelWand(), entity1);
            entity1.DisplayInventory();
            entity1.AddItemInventory(new FelWand(), entity1);
            entity1.AddItemInventory(new ScepterOfFrostfury(), entity1);
            entity1.AddItemInventory(new FelWand(), entity1);
            entity1.DisplayInventory();
        }
    }
}

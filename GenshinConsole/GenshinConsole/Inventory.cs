using System.Collections;
using System.Collections.Generic;

namespace GenshinConsole
{
    // Инвентарь в котором будет модифицированный вывод foreach и своя сортировка предметов
    // предметы будут представлять собой ...
    class Inventory : Item, IEnumerable
    {
        private SortedSet<Item> inventory = new SortedSet<Item>(new SortItem());

        const int DefaultCellsValue = 3;

        public void CheckCells(GameEntity entity)
        {
            foreach(Item item in inventory)
            {
                switch(item)
                {
                    case BeginnerBag bag:
                        entity.NumberOfCellsInventory = bag.NumberOfCells;
                        break;
                }
            }
        }

        public void ShowInventory()
        {
            foreach(Item item in inventory)
                System.Console.WriteLine(item);
        }

        public void AddItem(Item newItem, GameEntity entity)
        {
            if (inventory.Count < entity.NumberOfCellsInventory)
            {
                inventory.Add(newItem);
                System.Console.WriteLine("Предмет добавлен!");
            }
            else
            {
                System.Console.WriteLine("Недостаточно места!");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return inventory.GetEnumerator();
        }
    }
}

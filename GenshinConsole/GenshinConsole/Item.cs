using System;
using System.Collections;
using System.Collections.Generic;

namespace GenshinConsole
{

    // Родительский абстрактный класс который содержит в себе базовые поля для своих наследников
    class Item
    {
        public string NameItem { get; set; }
        private float _strength;
        private int _numberOfUses;
        public int Power { get; }
        public string Rarity { get; }

        public Item(string name = "item-name", int power = 20)
        {
            NameItem = name;
            Power = power;
        }

        public override string ToString()
        {
            return $"Name: {NameItem}, power: {Power}";
        }

        // Изменение прочности исходя из количество использований предмета
    }

    class SortItem : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            if (x.NameItem.Length > y.NameItem.Length)
                return -1;
            if (x.NameItem.Length < y.NameItem.Length)
                return 1;
            else
                return -1;
        }
    }
}

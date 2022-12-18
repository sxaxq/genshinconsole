using System;

namespace GenshinConsole
{
    class GameEntity
    {
        public string Name { get; set; }
        public float HealthPoint { get; set; }
        public float ArmourPoint { get; set; }
        public int DamagePoint { get; set; }
        public int NumberOfCellsInventory { get; set; } = 3;
        private Inventory inventoryEntity = new Inventory();

        public GameEntity(string name = "no-name", float hp = 100, float armour = 100
            , int damage = 7)
        {
            Name = name;
            HealthPoint = hp;
            ArmourPoint = armour;
            DamagePoint = damage;
        }

        // Делегация для взаимодействия с инвентарем

        public void UpdateCheck(GameEntity entity)
        { inventoryEntity.CheckCells(entity); }

        public void DisplayInventory()
        { inventoryEntity.ShowInventory(); }

        public void AddItemInventory(Item newItem, GameEntity entity)
        { inventoryEntity.AddItem(newItem, entity); }

        //

        public override string ToString()
        {
            return $"Name: {Name}, DMG: {DamagePoint}";
        }
    }
}

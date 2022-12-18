using System;

namespace GenshinConsole
{
    // Класс который будет содержать общие поля для категории предметов "Скипетр"
    abstract class Scepter : Item
    {
        public Scepter(string name, int power) : base(name, power) { }
    }

    class ScepterOfFrostfury : Scepter
    {
        public ScepterOfFrostfury() : base("Scepter Of Frostfury", 100) { }
    }

    class FelWand : Scepter
    {
        public FelWand() : base("Fel Wand", 90) { }
    }
}

namespace GenshinConsole
{
    abstract class TypeBag : Item
    {
        public int NumberOfCells { get; }

        public TypeBag(string name, int cells) : base(name, cells) { }
    }

    class BeginnerBag : TypeBag
    {
        public BeginnerBag() : base("Beginner Bag", 6) { }
    }
}

class Player : Person
{
    private int dorsal;

        public int Dorsal { get{return dorsal;} set{dorsal = value;} }
    public Player(int dorsal, string name, string surname) : base(name, surname)
    {
        this.dorsal = dorsal;
    }

    public override void introduce()
    {
        Console.WriteLine($"Hi, my name is {this.Name} {this.Surname} and my dorsal is {this.Dorsal}");
    }
}
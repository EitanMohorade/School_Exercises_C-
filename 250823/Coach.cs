class Coach : Person
{
    private Tactic tactic;
        public Tactic Tactic { get{return tactic;} set{tactic = value;}  }
    public Coach(Tactic tactic ,string name, string surname) : base(name, surname)
    {
            this.Tactic = tactic;
    }

    public override void introduce()
    {
        Console.WriteLine($"Hi, my name is {this.Name} {this.Surname} and my tactic is {this.Tactic}");
    }
}
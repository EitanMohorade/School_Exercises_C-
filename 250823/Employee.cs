class Employee : Person
{
    private string function;

        public string Function { get{return function;} set{function = value;} }
    public Employee(string function, string name, string surname) : base(name, surname)
    {
        this.function = function;
    }

    public override void introduce()
    {
        Console.WriteLine($"Hi, my name is {this.Name} {this.Surname} and my function is {this.Function}");
    }
}
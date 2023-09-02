abstract class Person
{
    private string surname;
    private string name;

        public string Name { get{return name;} set{name = value;} }
        public string Surname { get{return surname;} set{surname = value;} }
    public Person(string name, string surname)
    {
            this.Surname = surname;
            this.Name = name;
    }
    public abstract void introduce();
}
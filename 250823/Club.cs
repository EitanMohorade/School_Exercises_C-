class Club
{
    private string  name;
    private int age;
    private Address address;
    private List<Team> teamsList;
    private List<Employee> employeesList;

        public string Name { get{return name;} set{name = value;} }
        public int Age { get{return age;} set{age = value;} }
        public Address Address { get{return address;} set{address = value;} }
        public List<Employee> EmployeesList { get{return employeesList;} set{employeesList = value;} }
        public List<Team> TeamsList { get{return teamsList;} set{teamsList = value;} }
    public Club(string name, int age, Address address)
    {
            this.Address = address;
            this.Age = age;
            this.Name = name;
    }
    public void addTeam(Team team){
        TeamsList.Add(team);
    }
    public void removeTeam(Team team){
        if (!TeamsList.Contains(team))
        {
            TeamsList.Remove(team);
        }
    }
    public void addEmployee(Employee employee){
        EmployeesList.Add(employee);
    }
    public void removeEmployee(Employee employee){
        if(!employeesList.Contains(employee)){
            EmployeesList.Remove(employee);
        }
    }
}
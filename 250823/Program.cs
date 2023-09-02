// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
 Desarrollar los métodos del equipo  para añadir y quitar los jugadores de un equipo. 
 El método será agregarJugador y quitarJugador.

Desarrollar los métodos del club para quitar y agregar equipos. 
El método será agregarEquipo y removerEquipo, reciben un equipo.  

Desarrollar el metodo del club para agregar o quitar empleados.
*/
Address address = new Address("Anchorena", 3940, "Buenos Aires");
Player player1 = new Player(1, "Juan", "Martin");
Player player2 = new Player(2, "Ana", "Garcia");
Player player3 = new Player(3, "Pedro", "Lopez");
Player player4 = new Player(4, "Maria", "Perez");
Player player5 = new Player(5, "Luis", "Gomez");
Player player6 = new Player(6, "Laura", "Rodriguez");
Player player7 = new Player(7, "Carlos", "Hernandez");
Player player8 = new Player(8, "Sofia", "Fernandez");
Player player9 = new Player(9, "David", "Torres");
Player player10 = new Player(10, "Elena", "Martinez");
List<Player> playerList1 = new List<Player>
{
    player1,
    player2,
    player3
};
List<Player> playerList2 = new List<Player>
{
    player4,
    player5,
};
List<Player> playerList3 = new List<Player>
{
    player7,
    player8,
    player9,
    player10
};
Coach coach1 = new Coach(Tactic.DEFENSIVE ,"David", "Lobari");
Coach coach2 = new Coach(Tactic.OFFENSIVE ,"Carlos", "Martinez");
Coach coach3 = new Coach(Tactic.BALANCING ,"Maria", "Lobari");
Team team1 = new Team(Category.FIRST, playerList1, coach1);
Team team2 = new Team(Category.SECOND, playerList2, coach2);
Team team3 = new Team(Category.THIRD, playerList3, coach3);
Employee employee1 = new Employee("admin", "Pedro", "Sardar");
Employee employee2 = new Employee("admin", "Juan", "Lopez");
Employee employee3 = new Employee("admin", "Ana", "Perez");
Club club1 = new Club("RIVER", 3, address);
club1.addTeam(team1);
club1.addEmployee(employee1);
team2.addPlayer(player6);

class Team
{
    private Category category;
    private List<Player> playersList;
    private Coach coach;

        public Category Category { get{return category;} set{category = value;} }
        public List<Player> PlayersList { get{return playersList;} set{playersList = value;} }
        public Coach Coach { get{return coach;} set{coach = value;} }
    public Team(Category category, List<Player> playersList, Coach coach)
    {
        this.Coach = coach;
        this.PlayersList = playersList;
        this.category = category;
    }
    public void addPlayer(Player player){
        playersList.Add(player);
    }
    public void removePlayer(Player player){
        if(!playersList.Contains(player))
        {
            playersList.Remove(player);
        }
    }
}
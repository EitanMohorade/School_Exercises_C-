class PawnShop
{
    private string name;
    private List<Article> listArticles;
    private Direction direction;

    public string Name { get => name; set => name = value; }
    public List<Article> ListArticles { get => listArticles; set => listArticles = value; }
    public Direction Direction { get => direction; set => direction = value; }

    public PawnShop(string name, List<Article> listArticles, Direction direction){
        Name = name;
        ListArticles = listArticles;
        Direction = direction;
    }

    public void AddArticle(Article article){
        listArticles.Add(article);
    }
    public void RemoveArticle(string article) {
        for (int i = 0; i < listArticles.Count; i++)
        {
            if (listArticles[i].Name == article)
            {
                listArticles.RemoveAt(i);
            }
        }
    }
    public string searchArticle(string article){
        var count=0;
        while (listArticles.Count > count)
        {
            if (listArticles[count].Name == article)
            {
                return listArticles[count].Name;
            }
            count++;
        }
        return null;
    }
}
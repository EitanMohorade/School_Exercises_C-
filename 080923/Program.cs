// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Article article = new Article("asf", 12, false, Status.BAD, Category.ANTIQUITY);
Article article2 = new Article("thr", 53, true, Status.GOOD, Category.JEWEL);
Article article3 = new Article("herds", 3, true, Status.REGULAR, Category.ITEM);
Article article4 = new Article("FFFF", 2, true, Status.REGULAR, Category.ANTIQUITY);
List<Article> articles = new List<Article>
{
    article,
    article2,
    article3
};
Direction direction = new Direction("dsf", 1421, 1423);
PawnShop shop = new PawnShop("shop", articles, direction);

shop.AddArticle(article4);
shop.RemoveArticle("herds");

var searchArticle = shop.searchArticle(article2.Name);
if (searchArticle != null)
{
    Console.WriteLine("el articulo " + searchArticle + ", esta");    
}else
{
    Console.WriteLine("no se encontro el articulo");
}

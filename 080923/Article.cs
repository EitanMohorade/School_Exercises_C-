class Article
{
    private string name;
    private int price;
    private bool forSale;
    private Status status;
    private Category category;

    public Category Category { get => category; set => category = value; }
    public Status Status { get => status; set => status = value; }
    public bool ForSale { get => forSale; set => forSale = value; }
    public int Price { get => price; set => price = value; }
    public string Name { get => name; set => name = value; }

    public Article(string name, int price, bool forSale, Status status, Category category){
        Name = name;
        Price = price;
        ForSale = forSale;
        Status = status;
        Category = category;
    }
}
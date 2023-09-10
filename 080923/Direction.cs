class Direction
{
    private string street;
    private int houseNumber;
    private int postCode;

    public int PostCode { get => postCode; set => postCode = value; }
    public int HouseNumber { get => houseNumber; set => houseNumber = value; }
    public string Street { get => street; set => street = value; }

    public Direction(string street, int houseNumber, int postCode)
    {
        Street = street;
        HouseNumber = houseNumber;
        PostCode = postCode;
    }
}
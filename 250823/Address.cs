class Address
{
    private string street;
    private int high;
    private string city;

        public string Street { get{return street;} set{street = value;} }
        public int High { get{return high;} set{high = value;} }
        public string City { get{return city;} set{city = value;} }
    public Address(string street, int high, string city)
    {
            this.City = city;
            this.High = high;
            this.Street = street;
    }
}
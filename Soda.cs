namespace AddToArray
{
    public class Soda
    {
        public string? Name {get; set;}
        public int Price {get; set;}
        public int Stock {get; set;}

        public Soda(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
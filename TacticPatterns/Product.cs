namespace TacticPatterns
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(double price, string name)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
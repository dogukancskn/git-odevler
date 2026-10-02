namespace Odev5_List_Foreach;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Product p1 = new Product()
        {
            Id = 1,
            Name = "Ayakkabı",
            Price = 3500m,
        };
        Product p2 = new Product()
        {
            Id = 2,
            Name = "Gömlek",
            Price = 1500m,
        };
        Product p3 = new Product()
        {
            Id = 3,
            Name = "Pantolon",
            Price = 200m,
        };

        products.Add(p1);
        products.Add(p2);
        products.Add(p3);
        
        if (products.Count == 0)
        {
            Console.WriteLine("Üürn Yok");
        }
        foreach (Product product in products)
        {

            Console.WriteLine($"Ürün {product.Id}: {product.Name} - {product.Price}");
        }

        Console.WriteLine($"Toplam Ürün: {products.Count}");
    }
}

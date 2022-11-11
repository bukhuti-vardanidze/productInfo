namespace FirstPractise
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private double price;
        public static string marketName { get; set; }
        public double Price {
            get { return price; }
            set {
                if (value > 0) 
                { 
                    price = value;  
                }
            }
        }

        private double discount;
        public double Discount
        {
            get { return discount; }
            set
            {
                if(value >= 0)
                {
                    discount = value;
                }
            }
        }

        private double discountPrice;
        public double DiscountPrice
        {
            get { return discountPrice = Price * (1 - discount); }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3]
               {
                new Product { Name ="iphone", Description="screen protector", Price = 450, Discount=0.2  },
                new Product { Name = "samsung", Description = "screen protector", Price = 500, Discount = 0.3 },
                new Product { Name = "Xiaomi", Description = "screen protector", Price = 200, Discount = 0.1 },
               };


            printProduct(products);
            
            Console.ReadLine();

        }
        static void printProduct(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(Product.marketName);
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"description :: {product.Description}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($" Discoint:  {product.Discount *100}");
                Console.WriteLine($"DiscountPrice: {product.DiscountPrice}");
                
            }

        }



    }
}
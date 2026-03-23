namespace G_Net_34_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product{ID=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
                new Product{ID=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
                new Product{ID=3,Name="T-Shirt",Category="Clothing",Price=30,Stock=100},
                new Product{ID=4,Name="Jeans",Category="Clothing",Price=60,Stock=50},
                new Product{ID=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
                new Product{ID=6,Name="Coffee Beans",Category="Food",Price=15,Stock=80},
                new Product{ID=7,Name="C# Book",Category="Books",Price=45,Stock=30},
                new Product{ID=8,Name="Novel",Category="Books",Price=20,Stock=60},
                new Product{ID=9,Name="Headphones",Category="Electronics",Price=150,Stock=40},
                new Product{ID=10,Name="Jacket",Category="Clothing",Price=120,Stock=15},

            };
            #region Part01
            //Func<Product, bool> Condition = IsElectronic;
            //Helper.PrintList("Electronics", SearchProduct(catalog, IsElectronic));

            //Helper.PrintList("Cheaper Than 50$", SearchProduct(catalog, CheaperThan50));

            //Helper.PrintList("In Stock", SearchProduct(catalog, InStock));
            //Helper.PrintList("Cloth Under 100$", SearchProduct(catalog, ClothUnder100));
            #endregion
            #region Part02
            //Console.WriteLine();
            //Console.WriteLine("________________Short Report_______________");
            //PrintReport(catalog, PrintShort);

            //Console.WriteLine("_______________Details Report_______________");
            //PrintReport(catalog, PrintDetails);
            #endregion
            #region Part03
            //Console.WriteLine();
            //Helper.PrintList("Summary List", Transform_Products(catalog, SummaryList));
            //Helper.PrintList("Price Labels", Transform_Products(catalog, PriceLabels));
            #endregion
            #region Part04
            //Console.WriteLine();
            //PrintAfterFilter(FilterProduct(catalog, StockCheck));
            #endregion


        }
        #region Task01

        static Func<Product, bool> IsElectronic = p => p.Category == "Electronics";

        static Func<Product, bool> CheaperThan50 = p => p.Price < 50;

        static Func<Product, bool> InStock = p => p.Stock > 0;
        static Func<Product, bool> ClothUnder100 = p => p.Category == "Clothing" && p.Price < 100;


        public static List<Product> SearchProduct(List<Product> products, Func<Product, bool> c)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (c(product))
                    result.Add(product);
            }
            return result;
        }

        /// <summary>
        /// // Using Func<Product, bool> here to create a generic filter. 
       // It allows us to pass any search criteria (logic) as a parameter without changing the method's code.
        /// </summary>


        #endregion
        #region Task3.1
        static Action<Product> PrintShort = p => Console.WriteLine($"{p.Name} -${p.Price}");
        static Action<Product> PrintDetails = p => Console.WriteLine($"[{p.Category}] {p.Name}|Price :${p.Price} |Stock :{p.Stock}");
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (var item in products)
            {
                action(item);
            }
            Console.WriteLine();
        }


        /// <summary>
        /// // Action<Product> is used because we only need to perform an operation (printing) on each item. 
        // It doesn't need to return any value, just execute the provided display logic.
        /// </summary>
        #endregion
        #region Task3.2
        static Func<Product, string> SummaryList => p => $"{p.Name} (${p.Price})";
        static Func<Product, string> PriceLabels = p =>
        {
            string type;
            if (p.Price > 100)
                type = "Expensive!";
            else
                type = "Affordable";
            return $"{p.Name} :{type}";

        };
        public static List<string> Transform_Products(List<Product> products,Func<Product,string> func)
        {
            List<string> result = new();
            foreach (var item in products)
            {
                result.Add(func(item));
            }
            return result;
        }


        /// <summary>
        /// // We used Func<Product, string> to handle the transformation process. 
        // It takes a product object and returns a formatted string, which is perfect for generating labels or summaries.
        /// </summary>
        #endregion
        #region Task3.3
        static Predicate<Product> StockCheck = p => p.Stock < 20;
        public static List<Product> FilterProduct(List<Product> products,Predicate<Product> check)
        {
            List<Product>result = new();
            foreach (var item in products)
            {
                if(check(item))
                    result.Add(item);
            }
            return result;
        }
        static void PrintAfterFilter(List<Product> products)
        {
            Console.WriteLine(new string('_',15)+ "Low-Stock Alert" + new string('_',15));
            for(int i=0;i<products.Count;i++)
            {
                Console.WriteLine($"[LOW STOCK] {products[i].Name} : only {products[i].Stock} left!");
            }
        }
        //// Predicate<Product> is the ideal choice for this task as it's specifically designed 
        // for evaluating conditions and returning a boolean (true/false) for filtering collections.
        #endregion


    }
}

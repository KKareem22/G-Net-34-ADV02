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
            Func<Product, bool> Condition = IsElectronic;
            Helper.PrintList("Electronics", SearchProduct(catalog, IsElectronic));
            
            Helper.PrintList("Cheaper Than 50$", SearchProduct(catalog, CheaperThan50));
            
            Helper.PrintList("In Stock", SearchProduct(catalog, InStock));
            Helper.PrintList("Cloth Under 100$", SearchProduct(catalog, ClothUnder100));


        }
        #region Methods

        static Func<Product, bool> IsElectronic = p => p.Category == "Electronics";

        static Func<Product, bool> CheaperThan50 = p => p.Price < 50;

        static Func<Product, bool> InStock = p => p.Stock > 0;
        static Func<Product,bool>ClothUnder100=p=>p.Category== "Clothing" && p.Price < 100;


        public static List<Product> SearchProduct(List<Product> products,Func<Product,bool> c)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if(c(product))
                    result.Add(product);
            }
            return result;
        }

            
        #endregion
    }
}

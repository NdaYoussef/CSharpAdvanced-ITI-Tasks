namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeDbContext dbContext = new CoffeeDbContext();

            dbContext.Database.EnsureCreated();


            CoffeeBean bean = new CoffeeBean()
            {
                Id = 1,
                Name = "firstCoffe",
                OriginCountry = "Egypt",
                RoastLevel = 1,
                PricePerKeg = 50.0m,
                SupplierId = 1,
            };

            //1- 
            dbContext.Add(bean);
            dbContext.SaveChanges();

        }
    }
}

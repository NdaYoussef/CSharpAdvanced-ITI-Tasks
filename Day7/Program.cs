using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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
                //  Id = 1,
                Name = "firstCoffe",
                OriginCountry = "Egypt",
                RoastLevel = 1,
                PricePerKeg = 50.0m,
                SupplierId = 3,
            };

            Supplier supplier = new Supplier()
            {
                Name = "first Supplier",
                ContactNumber = 12457888,
                Email = "supplier@email.com"
            };


            CoffeeBean bean5 = new CoffeeBean()
            {

                Name = "Ethiopian Yirgacheffe",
                OriginCountry = "Ethiopia",
                RoastLevel = 2,
                PricePerKeg = 120.0m,
                SupplierId = 6
            };
            CoffeeBean bean6 = new CoffeeBean()
            {
                Name = "Colombian Supremo",
                OriginCountry = "Colombia",
                RoastLevel = 3,
                PricePerKeg = 95.5m,
                SupplierId = 5
            };



            Supplier supplier4 = new Supplier()
            {
                Name = "Nile Coffee Traders",
                ContactNumber = 11111111,
                Email = "nile@supplier.com"
            };
            Supplier supplier5 = new Supplier()
            {
                Name = "Global Beans Ltd",
                ContactNumber = 22222222,
                Email = "global@supplier.com"
            };
            Supplier supplier6 = new Supplier()
            {
                Name = "Premium Roasters",
                ContactNumber = 33333333,
                Email = "premium@supplier.com"
            };


            #region Add
            // dbContext.Suppliers.Add(supplier4);
            // dbContext.Suppliers.Add(supplier5);
            // dbContext.Suppliers.Add(supplier6);
            //// dbContext.Coffeebeans.Add(suppliers);
            // dbContext.Coffeebeans.Add(bean5);
            // dbContext.Coffeebeans.Add(bean6); 
            #endregion

            #region Get
            var supplierData = dbContext.Suppliers.FirstOrDefault(d => d.Id == 5);
            Console.WriteLine(supplierData.Name);

            var coffeeBeanData = dbContext.Coffeebeans.FirstOrDefault(p => p.Name == "firstCoffe");
            Console.WriteLine(coffeeBeanData.Id);
            #endregion
            #region #2 update 
            //var supplierUpdateName = dbContext.Suppliers.FirstOrDefault(d=>d.Id == 12);
            //supplierUpdateName.Name = "updated supplier name";
            //dbContext.Suppliers.Update(supplierUpdateName);

            //var coffeeUpdatedPrice = dbContext.Coffeebeans.FirstOrDefault(d=>d.Id == 4);
            //coffeeUpdatedPrice.PricePerKeg = 300.00m;
            //dbContext.Coffeebeans.Update(coffeeUpdatedPrice); 
            #endregion
            #region Deleter
            //var deletedInfoCoffee = dbContext.Coffeebeans.FirstOrDefault(id => id.Id == 11);
            //dbContext.Coffeebeans.Remove(deletedInfoCoffee);
            //Console.WriteLine("data removed successfully");
            #endregion
            var beans = dbContext.Coffeebeans.Where(p=>p.OriginCountry == "Colombia").Select(p => p.Name);
            foreach (var cBean in beans)
            {
                Console.WriteLine(cBean);
            }
            dbContext.SaveChanges();

        }
    }
}

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealEstateDbContext dbContext = new RealEstateDbContext();

            //-1 
            var properties = dbContext.PropertiesOwner.Select(p => new
            {
                PropertyId = p.PropertyId,
                OwnerId = p.OwnerId,
                Percentage = p.OwnershipPercentage
            });

            foreach ( var property in properties )
            {
                Console.WriteLine($"Property id: {property.PropertyId}, with Owner id: {property.OwnerId}, Percentage: {property.Percentage}");
            }

            Console.WriteLine("2 ==========================================================");

            //2-
            var offices = dbContext.SalesOffices.Where(p => p.ManagerId != null).Select(s => new
            {
                SalesOfficeNo = s.Number,
                ManagerOffice = s.ManagerId
            });
               

            foreach( var office in offices )
            {
                Console.WriteLine($"Office No: #{office.SalesOfficeNo}, Manager of the office: {office.ManagerOffice}");
            }

            Console.WriteLine("3 ==========================================================");
            //-3
            var Employees = dbContext.Employees.Select(e => new
            {
                EmployeeName = e.Name,
                EmployeeId = e.Id,
                SalesOfficeNo = e.SalesOfficeId,
                SalesOfficeLocation = e.SalesOffice.Location

            });

            foreach (var item in Employees)
            {
                Console.WriteLine($"Employee Name: {item.EmployeeName}, Employee Id: {item.EmployeeId}, Sales Office No: {item.SalesOfficeNo}, Sales Office Location: {item.SalesOfficeLocation}");
            }

            Console.WriteLine("4 ==========================================================");
            //-4
            var officeList = dbContext.SalesOffices.Where(p => !p.Properties.Any()).Select(s => new { Number = s.Number });

            foreach( var office in officeList )
            {
                if( office == null )
                Console.WriteLine("No office found!");

                Console.WriteLine($"office with no properties: {office.Number}");
            }

            Console.WriteLine("5 ==========================================================");
            //-5
            var totalPropAndEmps = dbContext.SalesOffices.Select(e => new
            {
                SalesOfficeNo = e.Number,
                TotalPropertiesCount = e.Properties.Count,
                TotalEmployeesCount = e.Employees.Count
            });

            foreach(var total in  totalPropAndEmps )
            {
                Console.WriteLine($"Office No: #{total.SalesOfficeNo} ,Total No of Employees: {total.TotalEmployeesCount}, Total No of Properties: {total.TotalPropertiesCount}");
            }


            Console.WriteLine("6 ==========================================================");
           // -6
            var owners = dbContext.Owners.Where(p =>p.PropertyOwners.Any()).Select(o => new { Name = o.Name });
            foreach (var own in owners)
            {
                Console.WriteLine($"Owner Name: {own}");
            }

            Console.WriteLine("7 ==========================================================");
            //-7
            var averageOwnership = dbContext.Properties.Select(p => new
            {
                PropertyAddress = p.Address,
                AvergePerProp = p.PropertyOwners.Average(avg => avg.OwnershipPercentage)
            });
           
            foreach (var owner in averageOwnership)
            {
                Console.WriteLine($"Prop address: {owner.PropertyAddress}, Average per Prop: {owner.AvergePerProp}");
            }

            Console.WriteLine("8 ==========================================================");
            //-8
            var propertiesDetails = dbContext.Properties.Where(e=>e.State =="Aswan").Select(e => new
            {
                PropertyId = e.Id,
                SalesOffice = e.SalesOfficeId,
                Owners = e.PropertyOwners
                           .Select(o=>o.Owner.Name)
            });

            foreach (var property in propertiesDetails)
            {
                Console.WriteLine($"Propoerty id: #{property.PropertyId}, Sales Office id: #{property.SalesOffice}");
                foreach(var owner in property.Owners)
                Console.WriteLine($"Owners: {owner}");
            }

            Console.WriteLine("9 ==========================================================");
            //-9
            //var Office = dbContext.SalesOffices.Where(p=>p.ManagerId).Select(s => new
            //{
            //    OfficeId = s.Number
            //});

            //foreach(var office in Office)
            //{
            //    Console.WriteLine($"Office Id: #{office.OfficeId}");
            //}

        }
    }
}

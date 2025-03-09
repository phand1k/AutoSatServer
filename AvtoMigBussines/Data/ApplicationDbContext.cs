using System.Collections.Generic;
using AvtoMigBussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AvtoMigBussines.Authenticate;
using AvtoMigBussines.CarWash.Models;
using AvtoMigBussines.Detailing.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

namespace AvtoMigBussines.Data
{
    public class ApplicationDbContext : IdentityDbContext<AspNetUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ForgotPasswordCode> ForgotPasswordCodes { get; set; }
        public DbSet<DetailingOrderTransaction> DetailingOrderTransactions { get; set; }
        public DbSet<DetailingService> DetailingServices { get; set; }
        public DbSet<DetailingPriceList> DetailingPriceLists { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TypeOfOrganization> TypeOfOrganizations { get; set; }
        public DbSet<DetailingOrder> DetailingOrders { get; set; }
        public DbSet<NotificationCenter> NotificationCenters { get; set; }
        public DbSet<WashOrderTransaction> WashOrderTransactions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<SalarySetting> SalarySettings { get; set; }
        public DbSet<WashService> WashServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<NotifiactionToken> NotifiactionTokens { get; set; }
        public DbSet<WashOrder> WashOrders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ModelCar> ModelCars { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<ClientOrganization> ClientOrganizations { get; set; }

        string filePath = "all-vehicles-model@public.csv";

        protected override void OnModelCreating(ModelBuilder builder)
        {
            HashSet<string> makes = new HashSet<string>();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool firstLine = true;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (firstLine)
                    {
                        firstLine = false;
                        continue; // Пропускаем заголовок
                    }

                    string[] columns = line.Split(';'); // Разделитель - ;
                    if (columns.Length > 0)
                    {
                        makes.Add(columns[0]); // Make - первый столбец
                    }
                }
            }
            List<Car> cars = makes.Distinct().Select((make, index) => new Car { Id = (index + 1), Name = make, IsDeleted = false }).ToList();

            foreach (var item in cars)
            {
                Console.WriteLine($"Seeding Car: Id = {item.Id}, Name = {item.Name}");
            }

            builder.Entity<Car>().HasData(cars);

            List<ModelCar> ModelCars = new List<ModelCar>();

            foreach (var line in File.ReadAllLines(filePath).Skip(1))
            {
                string[] columns = line.Split(';');

                if (columns.Length < 2) continue;

                string carName = columns[0].Trim();
                string[] carModels = columns[1].Split(',').Select(m => m.Trim()).ToArray();

                int? carId = cars.FirstOrDefault(car => car.Name == carName)?.Id;

                if (carId.HasValue)
                {
                    foreach (var model in carModels)
                    {
                        ModelCars.Add(new ModelCar
                        {
                            Id = ModelCars.Count + 1,
                            Name = model,
                            CarId = carId.Value,
                            IsDeleted = false
                        });
                    }
                }
            }

            builder.Entity<ModelCar>().HasData(ModelCars);
            
            
            builder.Entity<PaymentMethod>().HasData(
                new PaymentMethod
                {
                    Id = 1,
                    Name = "Наличный"
                },
                new PaymentMethod
                {
                    Id = 2,
                    Name = "Безналичный"
                },
                new PaymentMethod
                {
                    Id = 3,
                    Name = "Смешанная оплата"
                });

            builder.Entity<TypeOfOrganization>().HasData(
                new TypeOfOrganization
                {
                    Id = 1,
                    Name = "Detailing",
                },
                new TypeOfOrganization
                {
                    Id = 2,
                    Name = "Car wash"
                });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Мастер",
                    NormalizedName = "МАСТЕР"
                },
                new IdentityRole
                {
                    Name = "Менеджер",
                    NormalizedName = "МЕНЕДЖЕР"
                },
                new IdentityRole
                {
                    Name = "Директор",
                    NormalizedName = "Директор"
                }
                );
            
            base.OnModelCreating(builder);
        }
    }
}

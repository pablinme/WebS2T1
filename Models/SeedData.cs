
using S2T1.Data;
using Microsoft.EntityFrameworkCore;

namespace S2T1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new S2T1Context(serviceProvider.GetRequiredService<DbContextOptions<S2T1Context>>()))
            {
                if (context.Cliente.Any()) return;   // DB has been seeded
                
                context.Cliente.AddRange(
                    new Cliente
                    {
                        Id = 1,
                        Nombre = "Cliente",
                        Apellido = "1"
                    },
                    new Cliente
                    {
                        Id = 2,
                        Nombre = "Cliente",
                        Apellido = "2"
                    },
                    new Cliente
                    {
                        Id = 3,
                        Nombre = "Cliente",
                        Apellido = "3"
                    },
                    new Cliente
                    {
                        Id = 4,
                        Nombre = "Cliente",
                        Apellido = "4"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

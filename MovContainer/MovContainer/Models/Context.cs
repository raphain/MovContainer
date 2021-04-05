using Microsoft.EntityFrameworkCore;

namespace MovContainer.Models
{
    public class Context : DbContext
    {
        public DbSet<Container> Containers { get; set; }
        public DbSet<Movimentation> Movimentations { get; set; }

        public DbSet<MovType> MovTypes { get; set; }

        public DbSet<ContainerCategory> ContainerCategories { get; set; }

        public DbSet<ContainerStatus> ContainerStatuses { get; set; }

        public DbSet<ContainerType> ContainerTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=mov-dbserver;Integrated Security = True");
        }


    }
}

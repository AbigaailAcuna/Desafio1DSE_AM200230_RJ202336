using Microsoft.EntityFrameworkCore;
using Desafio1DSE_AM200230_RJ202336.Models.Seeds;

namespace Desafio1DSE_AM200230_RJ202336.Models
{
    public class EmpleadosDBContext: DbContext
    {
        public EmpleadosDBContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartamentoSeed());
            modelBuilder.ApplyConfiguration(new EmpleadoSeed());

        }
    }
}

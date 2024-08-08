using Microsoft.EntityFrameworkCore;

namespace Desafio1DSE_AM200230_RJ202336.Models
{
    public class EmpleadosDBContext: DbContext
    {
        public EmpleadosDBContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}

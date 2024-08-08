using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1DSE_AM200230_RJ202336.Models.Seeds
{
    public class DepartamentoSeed: IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder) {

            builder.HasData(
                new Departamento { ID = 1, NombreDepartamento = "Recursos Humanos" },
                new Departamento { ID = 2, NombreDepartamento = "Tecnología" },
                new Departamento { ID = 3, NombreDepartamento = "Ventas" }
                );
        }
    }
}

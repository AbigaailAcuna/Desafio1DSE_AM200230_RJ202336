using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1DSE_AM200230_RJ202336.Models
{
    public class Departamento
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre del departamento es requerido")]
        [Display(Name = "Nombre del Departamento")]
        public string NombreDepartamento { get; set; }

        [Display(Name = "Descripción del Departamento")]
        public string? DescripcionDepartamento { get; set; }

        //propiedad de navegación
        public ICollection<Empleado> Empleados { get; set; }





    }
}

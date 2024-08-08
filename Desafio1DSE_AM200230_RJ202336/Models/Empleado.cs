using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1DSE_AM200230_RJ202336.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "El nombre del empleado es requerido")]
        [Display(Name = "Nombre de Empleado")]
        public string NombreEmpleado { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario debe ser mayor que cero.")]
        public decimal SalarioEmpleado { get; set; }

        [Display(Name = "Descripción de Empleado")]
        public string? DesciprionEmpleado { get; set; }

        //propiedad llave foránea
        [Required]
        [ForeignKey("Departamento")]
        public int? DepartamentoId { get; set; }

        //propiedad de navegación
        public Departamento Departamento { get; set; }
    }
}

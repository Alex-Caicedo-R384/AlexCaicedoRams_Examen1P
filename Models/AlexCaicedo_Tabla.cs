using System.ComponentModel.DataAnnotations;

namespace AlexCaicedoRams_Examen1P.Models
{
    public class AlexCaicedo_Tabla
    {
        public int Id { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [Range(10, int.MaxValue, ErrorMessage = "El número máximo es de 10 dgitos")]
        [Display(Name = "Cédula")]
        public int? AcCedula { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]

        public string? AcNombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Apellido")]

        public string? AcApellido { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La validación es obligatorio")]
        [Display(Name = "Mayor de Edad")]
        public bool AcMayordeEdad { get; set; }

        [Range(450.00, 5072.99)]
        [Display(Name = "Ingresos")]
        public decimal AcIngresos { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La Fecha de Nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? AcFechaNacimiento { get; set; }

    }
}

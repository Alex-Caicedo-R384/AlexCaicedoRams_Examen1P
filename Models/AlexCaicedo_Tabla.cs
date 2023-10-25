using System.ComponentModel.DataAnnotations;

namespace AlexCaicedoRams_Examen1P.Models
{
    public class AlexCaicedo_Tabla
    {
        public int Id { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(10, ErrorMessage = "El número es demasiado largo")]
        public int AcCedula { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        public string? AcNombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(50)]
        public string? AcApellido { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La validación es obligatorio")]
        public bool AcMayordeEdad { get; set; }

        [Range(450.00, 5072.99)]
        public decimal AcIngresos { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La Fecha de Nacimiento es obligatoria")]
        [DataType(DataType.DateTime)]
        public DateTime? AcFechaNacimiento { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace PauloOlivo_ExamenP1.Models
{
    public class PO_Tablita
    {
        public int PO_TablitaId { get; set; }
        [Required]
        public float? PO_Tabla { get; set; }
        [Compare("PO_Apellido2")]
        public string? PO_Apellido { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string? PO_Apellido2 { get; set; }
        [Required]

        public bool PO_Precio { get; set; }
        [Required]

        public DateTime PO_Fecha { get; set; }
       

    }
}

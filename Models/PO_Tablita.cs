using System.ComponentModel.DataAnnotations;

namespace PauloOlivo_ExamenP1.Models
{
    public class PO_Tablita
    {
        public int PO_TablitaId { get; set; }
        [Required]
        public float? PO_Tabla { get; set; }
        [Compare("PO_Apellido")]
        public string? PO_Nombre { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string? PO_Apellido { get; set; }
        public bool PO_Precio { get; set; }
        [Range(1, 100)]
        public DateTime PO_Fecha { get; set; }
       

    }
}

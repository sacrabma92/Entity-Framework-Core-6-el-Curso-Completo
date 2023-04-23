using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityCore.Models
{
    [Table("Articulo")]
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }

        [Column("Titulo")]
        [Required(ErrorMessage = "El titulo es obligatorio")]
        [MaxLength(100)]

        public string TituloArticulo { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Longitud maxima superada")]
        public string Descripcion { get; set; }

        [Range(0.1, 5.0)]
        public double Calificacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

    }
}

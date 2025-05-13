using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        public string Descripcion { get; set; }
    }
}

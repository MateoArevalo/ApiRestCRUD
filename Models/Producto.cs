using System.ComponentModel.DataAnnotations;

namespace WebApiProducto.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public /* required */ string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Activo { get; set; }
    }
}
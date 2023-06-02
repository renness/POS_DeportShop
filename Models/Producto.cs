using System;
using System.ComponentModel.DataAnnotations;

namespace POS_DeportShop.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        public ProductoTipo? ProductoTipoId { get; set; }
        
        public Marca? Marca { get; set; }
        
        public Categoria CategoriaPorDefectoId { get; set; }

        public string? Codigo { get; set; }

         public string? Ean13 { get; set; }
        
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo Nombre no puede tener más de 255 caracteres.")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        [Range(0, 999999.99, ErrorMessage = "El campo Precio debe ser mayor o igual a cero.")]
        public decimal Precio { get; set; }

        [Range(0, 999999.99, ErrorMessage = "El campo Precio Por Mayor debe ser mayor o igual a cero.")]
        public decimal PrecioPorMayor { get; set; }
        
        [Range(0, 1000000, ErrorMessage = "El campo Cantidad debe ser mayor o igual a cero.")]
        public int Cantidad { get; set; }

        [Range(0, 1000000, ErrorMessage = "El campo Cantidad Minima debe ser mayor o igual a cero.")]
        public int CantidadMinima { get; set; }
        
        public bool AlertaStockBajo { get; set; }

        [Range(0, 100000, ErrorMessage = "El campo Stock Bajor Cantidad debe ser mayor o igual a cero.")]
        public int StockBajoCantidad { get; set; }

        [StringLength(50, ErrorMessage = "El campo Unidad no puede tener más de 50 caracteres.")]
        public string? Unidad { get; set; }

        public bool Estado { get; set; }
        
        public DateTime FechaCreacion { get; set; }
        
        public DateTime? FechaActualizacion { get; set; }
        
        public bool MostrarPrecio { get; set; }
        
        public bool EnVenta { get; set; }
        
        public Sucursal? SucursalPorDefectoId { get; set; }

        public ICollection<Proveedor>? Proveedores { get; set; }

        public ICollection<Categoria>? Categorias { get; set; }

        public ICollection<ProductoAtributo>? ProductosAtributo { get; set; }
    }
}

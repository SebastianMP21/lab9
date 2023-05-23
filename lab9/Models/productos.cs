//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productos()
        {
            this.detallesdepedidos = new HashSet<detallesdepedidos>();
        }
    
        public int idproducto { get; set; }
        public string nombreProducto { get; set; }
        public Nullable<int> idProveedor { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public string cantidadPorUnidad { get; set; }
        public Nullable<decimal> precioUnidad { get; set; }
        public Nullable<short> unidadesEnExistencia { get; set; }
        public Nullable<short> unidadesEnPedido { get; set; }
        public Nullable<short> nivelNuevoPedido { get; set; }
        public Nullable<short> suspendido { get; set; }
        public string categoriaProducto { get; set; }
    
        public virtual categorias categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallesdepedidos> detallesdepedidos { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}

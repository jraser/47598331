//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    
    public partial class DetalleOrdenVentaList_Result
    {
        public int ID_DetalleOrden { get; set; }
        public Nullable<int> ID_Orden { get; set; }
        public Nullable<int> ID_Producto { get; set; }
        public string Lote { get; set; }
        public string Codigo_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<int> Atendido { get; set; }
        public Nullable<int> Faltante { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    
    public partial class OrdenCompraList_Result
    {
        public int ID_Orden { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaContabilidad { get; set; }
        public string Nombres_Socio { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Estado { get; set; }
        public string Situacion { get; set; }
        public Nullable<int> ID_Sucursal { get; set; }
        public Nullable<int> ID_Almacen { get; set; }
        public string Direccion { get; set; }
    }
}

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
    
    public partial class OrdenVentaGet_Result
    {
        public int ID_Orden { get; set; }
        public int ID_Socio { get; set; }
        public Nullable<decimal> IGV { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaContabilidad { get; set; }
        public string ID_Moneda { get; set; }
        public string ID_FormaPago { get; set; }
        public string ID_CondicionPago { get; set; }
        public Nullable<int> ID_Sucursal { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public string Situacion { get; set; }
        public string Nombres_Socio { get; set; }
    }
}

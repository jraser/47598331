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
    
    public partial class ProductoXalmacen_Result
    {
        public int ID_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public string Codigo_Producto { get; set; }
        public Nullable<System.DateTime> Fecha_venci { get; set; }
        public string Almacen { get; set; }
        public string Sucursal { get; set; }
        public int ID_Almacen { get; set; }
        public int ID_Sucursal { get; set; }
        public string Lot { get; set; }
        public Nullable<int> Cantida { get; set; }
        public string Descripcion_Sucursal { get; set; }
    }
}
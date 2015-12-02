﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{
   public class Producto
    {
    public int   ID_Producto                 { get; set; }
    public decimal?   CostoProducto               { get; set; }
    public string   Codigo_Producto             { get; set; }
    public string   Descripcion_Producto        { get; set; }
    public int?   ID_Marca                    { get; set; }
    public string   Estado                      { get; set; }
    public int?   ID_Categoria                { get; set; }
    public int?   ID_SubCategoria             { get; set; }
    public string   UsuarioCreacion             { get; set; }
    public string UsuarioEliminacion { get; set; }
    public string UsuarioModificacion { get; set; }
    public string   FechaCreacion               { get; set; }
    public DateTime   FechaModificacion           { get; set; }
    public DateTime   FechaEliminacion            { get; set; }
    public string   Codigo_UMedida              { get; set; }
    public string Cod_Lote { get; set; }
    public decimal? Precio_CompBase { get; set; }
    public decimal? Precio_VenBase { get; set; }

    public decimal? Precios { get; set; }

    public DateTime? Fecha_venci { get; set; }
    }

   public class ProductoView:Producto
   {
       public string Categoria { get; set; }
       public string SubCategoria { get; set; }
       public int? ID_Almacen { get; set; }
       public int? ID_Sucursal { get; set; }
       public string Sucursal { get; set; }
       public string NombreEstado { get; set; }
       public string Marca { get; set; }
       public int ID_Socio { get; set; }

       public int ID_Precio { get; set; }
       public int? Cantida { get; set; }
       public string Lot { get; set; }
       public decimal? Precios { get; set; }
       public DateTime? Fecha_venci { get; set; }
   }  


   public class Precio 
   {
       public int? ID_Precio { get; set; }
       public int? ID_Producto { get; set; }
       public decimal? Precios { get; set; }
       public int? ID_Socio { get; set; }
         
       public string UsuarioCreacion { get; set; }
       public string UsuarioEliminacion { get; set; }
       public string UsuarioModificacion { get; set; }
       public string FechaCreacion { get; set; }
       public DateTime FechaModificacion { get; set; }
       public DateTime FechaEliminacion { get; set; }

       public DateTime? Fecha_vigen { get; set; }

       public string Tipo { get; set; }
       
   }

   public class PrecioView:Precio
   {
       public string  NombreSocio { get; set; }

   }

}
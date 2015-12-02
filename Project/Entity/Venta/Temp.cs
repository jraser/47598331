using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity.Venta
{
    public class Temp
    {
        public int IdTemp { get; set; }
        public int ID_TempDetalle { get; set; }
        public int ID_Socio { get; set; }
        public int ID_Producto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? CostoProducto { get; set; }
        public string Codigo_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public int? ID_Marca { get; set; }
        public string Estado { get; set; }
        public int? ID_Categoria { get; set; }
        public int? ID_SubCategoria { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Codigo_UMedida { get; set; }
        public string Unidad { get; set; }
        
        public string Cod_Lote { get; set; }
        public decimal? Precios { get; set; }  
    }


    public class TempView : Temp
    {
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public string NombreEstado { get; set; }


        public int ID_Precio { get; set; }
        public decimal? Precios { get; set; } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SocioNegocio
{
   public class Grupo
    {
        public int ID_Grupo { get; set; }
        public string Nombre { get; set; }
        public string TipoGrupo { get; set; }      
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public decimal? DescuentoPor { get; set; }
        public int ID_DetalleGrupo { get; set; }
        public int ID_Asociado { get; set; }
        public int ID_Socio { get; set; }
    }

   public class GrupoView : Grupo
   {

       public string Nombres_Socio { get; set; }
       public string Num_Documento { get; set; }
       public string Codigo_Producto { get; set; }
       public string Descripcion_Producto { get; set; }
       public string Marca { get; set; }
       public string Categoria { get; set; }
       public string SubCategoria { get; set; }

   }  
}

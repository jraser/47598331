using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SocioNegocio
{
    public class GrupoDetalleDAO
    {
        public List<GrupoView> DetalleGrupoSNList(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleGrupoSNList(ID_Grupo).ToList().
                Select(obj => new GrupoView
                {
                    ID_Grupo = obj.ID_Grupo,
                    ID_DetalleGrupo = obj.ID_DetalleGrupo,
                    ID_Asociado = obj.ID_Asociado,
                    Nombres_Socio = obj.Nombres_Socio,
                    Num_Documento = obj.Num_Documento
                }).ToList<GrupoView>();

            return list;
        }

        public List<GrupoView> DetalleGrupoProductosList(int ID_Grupo, int num)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleGrupoProductosList(ID_Grupo).ToList().
                Select(obj => new GrupoView
                {
                    ID_Grupo = obj.ID_Grupo,
                    ID_DetalleGrupo = obj.ID_DetalleGrupo,
                    ID_Asociado = obj.ID_Asociado,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    Marca = obj.Marca,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria
                }).ToList<GrupoView>();

            return list;
        }

        public string DetalleGrupoSNDelete(int ID_DetalleGrupo)
        {
            var context = new SIEPERU2Entities();
            context.DetalleGrupoSNDelete(ID_DetalleGrupo);

            return "";
        }


        public string DetalleGrupoSNCreate(Grupo obj)
        {

            var context = new SIEPERU2Entities();

            var Id = context.DetalleGrupoSNCreate(
                  obj.ID_DetalleGrupo,
                  obj.ID_Grupo,
                  obj.ID_Socio,
                  null,
                  null,
                  null).ToList();


            return Id[0].ToString();
        }


    }
}

using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class DescuentoGrupoDAO
    {

        public string DescuentoGrupoCreate(Descuento obj) 
        {
            var context = new SIEPERU2Entities();
            context.DescuentoGrupoCreate(
                obj.ID_Descuento,
                obj.ID_Grupo,
                obj.DescuentoPor,
                obj.Descripcion,
                obj.UsuarioCreacion,
                obj.UsuarioModificacion,
                obj.UsuarioEliminacion,
                null,
                null,
                null,
                ""
                );

            return "";
        }

        public List<DescuentoView> DescuentoGrupoList(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.DescuentoGrupoList(ID_Grupo).ToList().
                Select(obj => new DescuentoView
                {
                    ID_Descuento = obj.ID_Descuento,
                    ID_Grupo = obj.ID_Grupo,
                    DescuentoPor = obj.DescuentoPor,
                    Descripcion = obj.Descripcion,
                    Estado = obj.Estado
                }).ToList<DescuentoView>();

            return list;
        }


        public string DescuentoGrupoUpdate(int ID_Descuento, int ID_Grupo)
        {
            var context = new SIEPERU2Entities();
            context.DescuentoGrupoUpdate(ID_Descuento, ID_Grupo);

            return "";
        }

    }
}

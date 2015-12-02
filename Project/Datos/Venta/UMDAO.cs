using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class UMDAO
    {

        public string UnidadMedidaCreate(UM obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.UnidadMedidaCreate(
                 obj.ID_UnidadMedida,
                 obj.UnidadPresentacion,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Observacion,
                 obj.Codigo_UMedida,
                 obj.Cantidad,
                 obj.CantidaBase

                 ).ToList();

            return Id[0].ToString();
        }

        public List<UMView> UMList(string Nombre, string UnidadPresentacion)
        {

            var context = new SIEPERU2Entities();

            var list = context.UMList(Nombre, UnidadPresentacion).ToList().
                Select(obj => new UMView
                {
                    ID_UnidadMedida = obj.ID_UnidadMedida,
                    Nombre=obj.Nombre,
                    UnidadPresentacion=obj.UnidadPresentacion,
                    Cantidad=obj.Cantidad
                }).ToList<UMView>();
            return list;
        }


        public UM UMGet(int ID_UnidadMedida)
        {
            var context = new SIEPERU2Entities();
            var list = context.UMGet(ID_UnidadMedida).ToList().
                Select(obj => new UM
                {
                    ID_UnidadMedida = obj.ID_UnidadMedida,
                    Codigo_UMedida = obj.Codigo_UMedida,
                    UnidadPresentacion = obj.UnidadPresentacion,
                    Cantidad=obj.Cantidad,
                    CantidaBase = obj.CantidaBase,
                    Observacion=obj.Observacion
                   
                }).ToList<UM>()[0];

            return list;
        }



    }
}

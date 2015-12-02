using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
   public class DetalleRequerimientoDAO
    {
        public string DetalleRequerimientoCreate(DetalleRequerimiento obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.DetalleRequerimientoCreate(
                 obj.ID_RequerimientoDetalle,
                 obj.ID_Requerimientos,
                 obj.ID_DetalleOrden,
                 obj.Lote_Requermientos,
                 obj.ID_Producto,
                 obj.ID_Sucursal,
                 obj.ID_Almacen,
                 obj.CantidadRequisito,
                 obj.CantidadxMe,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Estado               
                 );

            return "";
        }

        public DetalleRequerimiento DetalleRequerimientoGet(int ID_RequerimientoDetalle, int ID_Requerimientos)
        {
            var context = new SIEPERU2Entities();

            var list = context.DetalleRequerimientoGet(ID_RequerimientoDetalle, ID_Requerimientos).ToList().
                Select(obj => new DetalleRequerimiento
                {

                    ID_RequerimientoDetalle = obj.ID_RequerimientoDetalle,
                    ID_Requerimientos=obj.ID_Requerimientos,
                    Lote_Requermientos = obj.Lote_Requermientos,
                    ID_Producto=obj.ID_Producto,
                    CantidadRequisito= obj.CantidadRequisito,
                    CantidadxMe=obj.CantidadxMe



                }).ToList<DetalleRequerimiento>()[0];

            return list;
        }


             public List<DetalleRequerimientoView> DetalleRequerimientoList(int ID_Requerimientos)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleRequerimientoList(ID_Requerimientos).ToList().
                Select(obj => new DetalleRequerimientoView
                {
                    ID_RequerimientoDetalle = obj.ID_RequerimientoDetalle,
                    ID_Requerimientos=obj.ID_Requerimientos,
                    Lote_Requermientos = obj.Lote_Requermientos,
                    ID_Producto=obj.ID_Producto,
                    CantidadRequisito= obj.CantidadRequisito,
                    CantidadxMe=obj.CantidadxMe


                }).ToList<DetalleRequerimientoView>();

            return list;
        }
    }
}




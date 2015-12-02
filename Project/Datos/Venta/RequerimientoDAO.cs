using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Venta
{
    public class RequerimientoDAO
    {
        public string RequerimientosCreate(Requerimientos obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.RequerimientosCreate(
                  obj.ID_Requerimientos,
                  obj.Numero_Req,
                  obj.TipoDocumento,
                  obj.NroDocumento,
                  obj.FechaEmision,
                  obj.FechaEntrega,
                  obj.FechaContabilidad,
                  obj.ID_Sucursal,
                  obj.ID_Almacen,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  obj.Estado,
                  obj.Motivo

                  ).ToList();

            return Id[0].ToString();

        }

        public List<RequerimientosView> RequerimientosList(string Descripcion_Sucursal, string Descripcion_Almacen, DateTime FechaInI, DateTime FechaFin, string Estado)
        {

            var context = new SIEPERU2Entities();

            var list = context.RequerimientosList(Descripcion_Sucursal, Descripcion_Almacen, FechaInI, FechaFin, Estado).ToList().
                Select(obj => new RequerimientosView
                {
                    ID_Requerimientos = obj.ID_Requerimientos,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    Descripcion_Sucursal = obj.Descripcion_Sucursal,
                    Descripcion_Almacen = obj.Descripcion_Almacen,
                    Estado = obj.Estado,

                }).ToList<RequerimientosView>();

            return list;
        }

        public Requerimientos RequerimientoGet(int ID_Requerimientos)
        {
            var context = new SIEPERU2Entities();

            var list = context.RequerimientoGet(ID_Requerimientos).ToList().
                Select(obj => new Requerimientos
                {
                    ID_Requerimientos = obj.ID_Requerimientos,
                    ID_Sucursal = obj.ID_Sucursal,
                    ID_Almacen = obj.ID_Almacen,
                    Numero_Req = obj.Numero_Req,
                    FechaContabilidad = obj.FechaContabilidad,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,

                    Motivo = obj.Motivo,
                    Descripcion_Almacen = obj.Descripcion_Almacen,
                    Descripcion_Sucursal = obj.Descripcion_Sucursal,
                    Estado = obj.Estado,
                    UsuarioCreacion = obj.UsuarioCreacion,
                    UsuarioModificacion = obj.UsuarioModificacion,
                    UsuarioEliminacion = obj.UsuarioEliminacion,
                    FechaCreacion = obj.FechaCreacion,
                    FechaModificacion = obj.FechaModificacion,
                    FechaEliminacion = obj.FechaEliminacion


                }).ToList<Requerimientos>()[0];

            return list;
        }
    }
}

using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Venta
{
    public class RequerimientoBL
    {

        RequerimientoDAO Dao = new RequerimientoDAO();

        public string RequerimientosCreate(Requerimientos obj)
        {
            return Dao.RequerimientosCreate(obj);
        }

        public List<RequerimientosView> RequerimientosList(string Descripcion_Sucursal, string Descripcion_Almacen, DateTime FechaINI, DateTime FechaFin, string Estado)
        {
            return Dao.RequerimientosList(Descripcion_Sucursal, Descripcion_Almacen, FechaINI, FechaFin, Estado);
        }

        public Requerimientos RequerimientoGet(int ID_Requerimientos)
        {
            return Dao.RequerimientoGet(ID_Requerimientos);
        }

    }
}

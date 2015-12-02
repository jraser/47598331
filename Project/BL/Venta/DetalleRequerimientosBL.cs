using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
public class DetalleRequerimientoBL
    {
         DetalleRequerimientoDAO Dao = new DetalleRequerimientoDAO();

        public string DetalleRequerimientoCreate(DetalleRequerimiento obj)
        {

            return Dao.DetalleRequerimientoCreate(obj);

        }

        public List<DetalleRequerimientoView> DetalleRequerimientoList(int ID_Requerimientos)
        {

            return Dao.DetalleRequerimientoList(ID_Requerimientos);

        }

        public DetalleRequerimiento DetalleRequerimientoGet(int ID_RequerimientoDetalle, int ID_Requerimientos)
        {
            return Dao.DetalleRequerimientoGet(ID_RequerimientoDetalle, ID_Requerimientos);

        }

    }





}

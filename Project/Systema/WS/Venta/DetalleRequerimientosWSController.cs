using BL.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace Systema.WS.Venta
{
  public class DetalleRequerimientosWSController :ApiController
    {

        public string Post(DetalleRequerimiento obj)
        {
            DetalleRequerimientoBL bl = new DetalleRequerimientoBL();
            return bl.DetalleRequerimientoCreate(obj);

        }
        public DetalleRequerimiento Get(int ID_RequerimientoDetalle, int ID_Requerimientos)
        {
            DetalleRequerimientoBL bl = new DetalleRequerimientoBL();
            return bl.DetalleRequerimientoGet(ID_RequerimientoDetalle, ID_Requerimientos);

        }

        public List<DetalleRequerimientoView> Get(int ID_Requerimientos)
        {
            DetalleRequerimientoBL bl = new DetalleRequerimientoBL();
            return bl.DetalleRequerimientoList(ID_Requerimientos);
        }


    }
}
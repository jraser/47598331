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
    public class DescuentoGrupoWSController : ApiController
    {
        public string Post(Descuento obj)
        {
            DescuentoGrupoBL bl = new DescuentoGrupoBL();
            return bl.DescuentoGrupoCreate(obj);
        }
        public List<DescuentoView> Get(int ID_Grupo)
        {
            DescuentoGrupoBL bl = new DescuentoGrupoBL();
            return bl.DescuentoGrupoList(ID_Grupo);
        }

        public string Delete(int ID_Descuento, int ID_Grupo)
        {
            DescuentoGrupoBL bl = new DescuentoGrupoBL();
            return bl.DescuentoGrupoUpdate(ID_Descuento, ID_Grupo);
        }
    }
}

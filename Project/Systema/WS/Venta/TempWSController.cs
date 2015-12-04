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
    public class TempWSController : ApiController
    {

        public string Post(Temp obj)
        {
            TempBL bl = new TempBL();
            return bl.TempCreate(obj);
        }

        public List<TempView> Get(int ID_TempDetalle)
        {
            TempBL bl = new TempBL();
            return bl.TempList(ID_TempDetalle);
        }

        public string Delete(int IdTemp)
        {
            TempBL bl = new TempBL();
            return bl.TempDelete(IdTemp);
        }

        public string Delete(int IdTemp, decimal Precio, int Cantidad, int ID_UnidadMedida, decimal CB, decimal CP)
        {
            TempBL bl = new TempBL();
            return bl.TempUpdate(IdTemp, Precio, Cantidad, ID_UnidadMedida, CB, CP);
        }

        public string Delete(int IdTemp, int ID_UnidadMedida, decimal CB, decimal CP)
        {
            TempBL bl = new TempBL();
            return bl.TempUpdateUM(IdTemp, ID_UnidadMedida, CB, CP);
        }
    }
}
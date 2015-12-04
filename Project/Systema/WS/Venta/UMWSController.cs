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
    public class UMWSController : ApiController
    {


        public string Post(UM obj)
        {
            UMBL bl = new UMBL();
            return bl.UnidadMedidaCreate(obj);
        }



        public List<UMView> Get(string Nombre, string UnidadPresentacion)
        {
            UMBL bl = new UMBL();
            return bl.UMList(Nombre, UnidadPresentacion);
        }


        public UM Get(int ID_UnidadMedida)
        {
            UMBL bl = new UMBL();
            return bl.UMGet(ID_UnidadMedida);
        }

        public List<UM> Get(string Codigo_UMedida, int Ayuda)
        {
            UMBL bl = new UMBL();
            return bl.UnidadMedidaUMList(Codigo_UMedida, Ayuda);

        }
    }
}

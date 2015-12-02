using BL.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//Precioqs

namespace Systema.WS.Venta
{
    public class PrecioWSController : ApiController
    {
        public string Post(Precio obj)
        {
            PrecioBL bl = new PrecioBL();
            return bl.PrecioCreate(obj);
        }
        public List<PrecioView> Get(int ID_Producto)
        {
            PrecioBL bl = new PrecioBL();
            return bl.PrecioList(ID_Producto);
        }


        public List<PrecioView> Get(int ID_Producto, string Tipo)
        {
            Tipo = "Cliente";

            PrecioBL bl = new PrecioBL();
            return bl.CPrecioList(ID_Producto,Tipo);
        }

        //public Precio GetPrecio(int ID_Precio,int cod)
        //{ 
        //    PrecioBL bl = new PrecioBL();
        //    return bl.PrecioGet(ID_Precio);
        //}
    }
}

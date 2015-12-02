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

    public class AlmacenWSController : ApiController
    {
        public List<Almacen> Get(String Descripcion_Almacen, String Estado)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenList(Descripcion_Almacen, Estado);
        }

        public List<Almacen> Get()
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.dll_AlmacenList();
        }


        public List<Almacen> Get(int ID_Sucursal)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.A2lmacenList2(ID_Sucursal);

        }
        public string Post(Almacen obj)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenCreate(obj);
        }

        public Almacen Get(int ID_Almacen, int bot)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenGet(ID_Almacen, 0);
        }

        public string Delete(int ID_Almacen)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenDelete(ID_Almacen);
        }

        public List<ProductoView> Get(string Descripcion_Producto, int ID_Almacen, int ID_Sucursal)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoXalmacen(Descripcion_Producto, ID_Almacen, ID_Sucursal);
        }
    }
}

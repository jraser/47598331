using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class TempBL
    {
        TempDAO  Dao = new TempDAO();
	//hola mundo

        public string TempCreate(Temp  obj)
        {

            return Dao.TempCreate(obj);

        }

        public List<TempView> TempList(int ID_TempDetalle)
        {

            return Dao.TempList(ID_TempDetalle);

        }

        public string TempDelete(int IdTemp)
        {

            Dao.TempDelete(IdTemp);
            return "";
        }

        public string TempUpdate(int IdTemp, decimal Precio, int Cantidad)
        {

            Dao.TempUpdate(IdTemp, Precio, Cantidad);
            return "";
        }
        
    }
}

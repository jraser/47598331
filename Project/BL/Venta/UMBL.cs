using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class UMBL
    {
        UMDAO Dao = new UMDAO();
 
        public string UnidadMedidaCreate(UM obj)
        {

            return Dao.UnidadMedidaCreate(obj);

        }

        public List<UMView> UMList(string Nombre, string UnidadPresentacion)
        {

            return Dao.UMList(Nombre, UnidadPresentacion);

        }


        public UM UMGet(int ID_UnidadMedida)
        {
            return Dao.UMGet(ID_UnidadMedida);
        }

        public List<UM> UnidadMedidaUMList(string Codigo_UMedida, int Ayuda)
        {
            return Dao.UnidadMedidaUMList(Codigo_UMedida, Ayuda);
        }
    }
}

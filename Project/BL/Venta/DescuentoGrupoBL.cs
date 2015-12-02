using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DescuentoGrupoBL
    {
        DescuentoGrupoDAO Dao = new DescuentoGrupoDAO();
        public string DescuentoGrupoCreate(Descuento obj)
        {
             
            return Dao.DescuentoGrupoCreate(obj);
        }
        public List<DescuentoView> DescuentoGrupoList(int ID_Grupo)
        {
            return Dao.DescuentoGrupoList(ID_Grupo);
        }
        public string DescuentoGrupoUpdate(int ID_Descuento, int ID_Grupo)
        {
            return Dao.DescuentoGrupoUpdate(ID_Descuento, ID_Grupo);
        }
    }
}

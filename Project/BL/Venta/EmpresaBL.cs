using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class EmpresaBL
    {

        EmpresaDAO Dao = new EmpresaDAO();
        public List<Empresa> dll_EmpresaList()
        {
            return Dao.dll_EmpresaList();
        }

        public List<Empresa> EmpresaList(string RazonSocial)
        {
            return Dao.EmpresaList(RazonSocial);
        }


    }


}

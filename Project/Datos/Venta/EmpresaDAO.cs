using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class EmpresaDAO
    {

        public List<Empresa> EmpresaList(string RazonSocial)
        {

            var context = new SIEPERU2Entities();

            var list = context.EmpresaList(RazonSocial).ToList().
                Select(obj => new Empresa
                {
                    ID_Empresa = obj.ID_Empresa,
                    RazonSocial = obj.RazonSocial,
                    Ruc = obj.Ruc,
                   Telefono=obj.Telefono
                }).ToList<Empresa>();

            return list;
        }



        public List<Empresa> dll_EmpresaList()
        {
            var context = new SIEPERU2Entities();
            var list = context.dll_EmpresaList().ToList().
                Select(obj => new Empresa
                {
                    ID_Empresa = obj.ID_Empresa,
                    RazonSocial = obj.RazonSocial,
                    Ruc = obj.Ruc,
                    Telefono = obj.Telefono
                }).ToList<Empresa>();
            return list;
        }



    }
}

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
    public class EmpresaWSController : ApiController
    {

        public List<Empresa> Get()
        {
            EmpresaBL bl = new EmpresaBL();
            return bl.dll_EmpresaList();
        }
        public List<Empresa> Get(string RazonSocial)
        {
            EmpresaBL bl = new EmpresaBL();
            return bl.EmpresaList(RazonSocial);
        }

    }
}

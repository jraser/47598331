using BL.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.SocioNegocio
{
    public class SocioNegocioWSController : ApiController
    {

        public List<Socio> Get()
        {
            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.dll_SocioNegocioList();
        }

        public string Post(Socio obj)
        {
            SocioNegocioBL bl = new SocioNegocioBL();
            if (obj.ID_Socio != 0)
            {
                return bl.SocioNegocioUpdate(obj);
            }
            else
            {
                return bl.SocioNegocioCreate(obj);
            }

        }

        public Socio Get(int ID_Socio)
        {
            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.SocioNegocioGet(ID_Socio);

        }

        public List<SocioView> Get(string Nombres, string Nro_Documento, string TipoSocio)
        {
            
            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.SocioNegocioList(Nombres, Nro_Documento, TipoSocio);

        }
        public string Delete(int ID_Socio)
        {
            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.SocioNegocioDelete(ID_Socio);
        }




        public List<Socio> Get(string TipoSocio, string Nombres)
        {
            TipoSocio = "C";
            Nombres = "";

            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.ddl_SocioNegocioList(TipoSocio, Nombres);

        }

        public List<Socio> GET2(string TipoSocio, string nom,int bug)
        {
            TipoSocio = "C";           
            SocioNegocioBL bl = new SocioNegocioBL();
            return bl.ddl_SocioNegocioList2(TipoSocio, nom,bug);

        }
    

    }
}


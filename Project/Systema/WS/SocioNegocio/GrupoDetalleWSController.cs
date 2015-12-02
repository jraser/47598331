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
    public class GrupoDetalleWSController : ApiController
    {

        public List<GrupoView> Get(int ID_Grupo)
        {
            GrupoDetalleBL bl = new GrupoDetalleBL();
            return bl.DetalleGrupoSNList(ID_Grupo);
        }

        public List<GrupoView> Get(int ID_Grupo, int num)
        {
            GrupoDetalleBL bl = new GrupoDetalleBL();
            return bl.DetalleGrupoProductosList(ID_Grupo, num);
        }

        public string Post(Grupo obj)
        {
            GrupoDetalleBL bl = new GrupoDetalleBL();
            return bl.DetalleGrupoSNCreate(obj);
        }

        public string Delete(int ID_DetalleGrupo)
        {
            GrupoDetalleBL bl = new GrupoDetalleBL();
            return bl.DetalleGrupoSNDelete(ID_DetalleGrupo);
        }



    }
}
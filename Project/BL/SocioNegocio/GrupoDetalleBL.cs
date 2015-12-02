using Datos.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.SocioNegocio
{
    public class GrupoDetalleBL
    {
        GrupoDetalleDAO Dao = new GrupoDetalleDAO();


        public List<GrupoView> DetalleGrupoSNList(int ID_Grupo)
        {

            return Dao.DetalleGrupoSNList(ID_Grupo);
        }

        public List<GrupoView> DetalleGrupoProductosList(int ID_Grupo, int num)
        {

            return Dao.DetalleGrupoProductosList(ID_Grupo, num);
        }

        public string DetalleGrupoSNCreate(Grupo obj)
        {


            return Dao.DetalleGrupoSNCreate(obj);
        }

        public string DetalleGrupoSNDelete(int ID_DetalleGrupo)
        {

            Dao.DetalleGrupoSNDelete(ID_DetalleGrupo);
            return "";
        }




    }
}

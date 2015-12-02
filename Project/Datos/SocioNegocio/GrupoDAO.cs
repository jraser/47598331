using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SocioNegocio
{
    public class GrupoDAO
    {


        public List<Grupo> GrupoList(string Nombre, string TipoGrupo, string Estado)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoList(Nombre,TipoGrupo, Estado).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    TipoGrupo = obj.TipoGrupo,
                    Estado = obj.Estado,
                }).ToList<Grupo>();

            return list;
        }

        public List<Grupo> GrupoSNList(string Nombre, string TipoGrupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoSNList(Nombre, TipoGrupo).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    TipoGrupo = obj.TipoGrupo,
                    Estado = obj.Estado,
                    DescuentoPor = obj.DescuentoPor
                }).ToList<Grupo>();

            return list;
        }

        public string GrupoCreate(Grupo obj)
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoCreate(
                  obj.ID_Grupo,
                  obj.Nombre,
                  obj.TipoGrupo,
                  obj.UsuarioCreacion,
                  obj.UsuarioModificacion,
                  obj.UsuarioEliminacion,
                  null,
                  null,
                  null,
                  "").ToList();


            return Id[0].ToString();
        }

        public Grupo GrupoGet(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoGet(ID_Grupo).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    TipoGrupo = obj.TipoGrupo,
                    Estado = obj.Estado,
                }).ToList<Grupo>()[0];

            return list;
        }

        public string GrupoDelete(int ID_Grupo) 
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoDelete(
                  ID_Grupo);


            return "";
        }

        public string GGrupoMod(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();
            var Id = context.GGrupoMod(ID_Grupo);
            return "";
        }

        public string GrupoEliminar(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoEliminar(
                  ID_Grupo);

            return "";
        }
        public Grupo GrupoSNGet(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoSNGet(ID_Grupo).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    TipoGrupo = obj.TipoGrupo,
                    DescuentoPor = obj.DescuentoPor,
                }).ToList<Grupo>()[0];

            return list;
        }
    }
}

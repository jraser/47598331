using System.Web.Mvc;

namespace Systema.Areas.SocioNegocio  
{
    public class SocioNegocioAreaRegistration : AreaRegistration  
    {
        public override string AreaName 
        {
            get  
            {
                return "SocioNegocio";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
        context.MapRoute(
        name: "GrupoList",
        url: "Grupo/List",
        defaults: new { controller = "Grupo", action = "List" });

        context.MapRoute(
        name: "GrupoCreate",
        url: "Grupo/Create",
        defaults: new { controller = "Grupo", action = "Create" });

        context.MapRoute(
        name: "GrupoModific",
        url: "Grupo/Modific",
        defaults: new { controller = "Grupo", action = "Modific" });

        context.MapRoute(
        name: "SocioNegocioList",
        url: "SocioNegocio/List",
        defaults: new { controller = "SocioNegocio", action = "List" });
       
        context.MapRoute(
        name: "SocioNegocioCreate",
        url: "SocioNegocio/Create",
        defaults: new { controller = "SocioNegocio", action = "Create" });

       context.MapRoute(
       name: "SocioAdd",
       url: "SocioNegocio/ListAdd",
       defaults: new { controller = "SocioNegocio", action = "ListAdd" });
       
       context.MapRoute(
       name: "SocioAddCliente",
       url: "SocioNegocio/ListAddCliente",
       defaults: new { controller = "SocioNegocio", action = "ListAddCliente" });

       context.MapRoute(
        name: "SocioNegocioGrupoSN",
        url: "SocioNegocio/GrupoSN",
        defaults: new { controller = "SocioNegocio", action = "GrupoSN" });

       context.MapRoute(
        name: "SocioNegocioGrupoSNAdd",
        url: "SocioNegocio/GrupoSNAdd",
        defaults: new { controller = "SocioNegocio", action = "GrupoSNAdd" });
        
        context.MapRoute(
        name: "SocioNegocioAddSNGrupo",
        url: "SocioNegocio/AddSNGrupo",
        defaults: new { controller = "SocioNegocio", action = "AddSNGrupo" });

        context.MapRoute(
         name: "SocioNegocioGrupoProductos",
         url: "SocioNegocio/GrupoProductos",
         defaults: new { controller = "SocioNegocio", action = "GrupoProductos" });

        context.MapRoute(
         name: "SocioNegocioGrupoProductosAdd",
         url: "SocioNegocio/GrupoProductosAdd",
         defaults: new { controller = "SocioNegocio", action = "GrupoProductosAdd" });

        context.MapRoute(
        name: "SocioNegocioAddProductosGrupo",
        url: "SocioNegocio/AddProductosGrupo",
        defaults: new { controller = "SocioNegocio", action = "AddProductosGrupo" });
        }
    
        
    }
}
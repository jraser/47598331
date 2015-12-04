using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Datos.Venta
{
    public class TempDAO
    {
        public string TempCreate(Temp obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.TempCreate(
                 obj.IdTemp,
                 obj.ID_TempDetalle,
                 obj.ID_Socio,
                 obj.ID_Producto,
                 obj.Precios,
                 1,
                 0,
                 0,
                 0
                 );

            return "";
        }
        public List<TempView> TempList(int ID_TempDetalle)
        {

            var context = new SIEPERU2Entities();

            var list = context.TempList(ID_TempDetalle).ToList().
                Select(obj => new TempView
                {
                    ID_Producto = obj.ID_Producto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    Codigo_UMedida = obj.Codigo_UMedida,
                    Unidad = obj.Unidad,
                    Estado = obj.Estado,
                    ID_Precio = obj.ID_Precio,
                    Precios = obj.Precio,                  
                    IdTemp = obj.IdTemp,
                    Cantidad = obj.Cantidad,
                    ID_UnidadMedida = obj.ID_UnidadMedida,
                    CB = obj.CB,
                    CP = obj.CP,
                    UnidadPresentacion = obj.UnidadPresentacion

                }).ToList<TempView>();

            return list;
        }

        public string TempDelete(int IdTemp)
        {
            var context = new SIEPERU2Entities();
            context.TempDelete(IdTemp);

            return "";
        }

<<<<<<< HEAD
        //public string TempUpdate(int IdTemp, decimal Precio, int Cantidad)
        //{
        //    var context = new SIEPERU2Entities();
        //    context.TempUpdate(IdTemp, Precio, Cantidad);
=======
        public string TempUpdate(int IdTemp, decimal Precio, int Cantidad, int ID_UnidadMedida, decimal CB, decimal CP)
        {
            var context = new SIEPERU2Entities();
            context.TempUpdate(IdTemp, Precio, Cantidad, ID_UnidadMedida, CB, CP);

            return "";
        }

        public string TempUpdateUM(int IdTemp, int ID_UnidadMedida, decimal CB, decimal CP)
        {
            var context = new SIEPERU2Entities();
            context.TempUpdateUM(IdTemp, ID_UnidadMedida, CB, CP);
>>>>>>> origin/master

        //    return "";
        //}
        
        

    }
}

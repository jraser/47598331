using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class ProductoBL
    {
        ProductoDAO Dao = new ProductoDAO();
        public List<ProductoView> ProductoList(string Descripcion, int ID_Categoria, int ID_SubCategoria)
        {

            return Dao.ProductoList(Descripcion, ID_Categoria, ID_SubCategoria);

        }

      public string ProductoCreate(Producto obj)
      {

         return Dao.ProductoCreate(obj);
           
      }

      public string ProductoDelete(int ID_Producto)
      {

          Dao.ProductoDelete(ID_Producto);
          return "";
      }


      public List<ProductoView> ProductoGet2(int ID_Producto, int num)
      {

        return  Dao.ProductoGet2(ID_Producto, num);
          
      }

      public Producto ProductoGet(int ID_Producto)
      {

          return Dao.ProductoGet(ID_Producto);

      }

      public List<ProductoView> ProductoBySocioList(string Descripcion, int ID_Categoria, int ID_SubCategoria, int ID_Socio)
      {

          return Dao.ProductoBySocioList(Descripcion, ID_Categoria, ID_SubCategoria, ID_Socio);

      }

      public List<ProductoView> DetalleGrupoProductoAddList(string Descripcion_Producto, string ID_Marca, string ID_Categoria, string ID_SubCategoria)
      {

          return Dao.DetalleGrupoProductoAddList(Descripcion_Producto, ID_Marca, ID_Categoria, ID_SubCategoria);
      }


      public List<ProductoView> ProductoXalmacen(string Descripcion_Producto, int ID_Almacen, int ID_Sucursal)
      {

          return Dao.ProductoXalmacen(Descripcion_Producto, ID_Almacen, ID_Sucursal);

      }
    }
}

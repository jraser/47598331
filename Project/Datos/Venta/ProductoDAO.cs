using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class ProductoDAO
    {

        public string ProductoCreate(Producto obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.ProductoCreate(
                 obj.ID_Producto,
                 obj.CostoProducto,
                 obj.Codigo_Producto,
                 obj.Descripcion_Producto,
                 obj.ID_Marca,
                 "",
                 obj.ID_Categoria,
                 obj.ID_SubCategoria,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Codigo_UMedida,
                 obj.Cod_Lote,
                 obj.Precio_CompBase,
                 obj.Precio_VenBase,
                 obj.Fecha_venci
                 ).ToList();

            return Id[0].ToString();
        }


        public List<ProductoView> ProductoList(string Descripcion, int ID_Categoria, int ID_SubCategoria)
        {

            var context = new SIEPERU2Entities();

            var list = context.ProductoList(Descripcion, ID_Categoria, ID_SubCategoria).ToList().
                Select(obj => new ProductoView
                {
                    ID_Producto = obj.ID_Producto,
                    CostoProducto = obj.CostoProducto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    Estado = obj.Estado,
                    NombreEstado = obj.NombreEstado,
                    Fecha_venci=obj.Fecha_venci,
                }).ToList<ProductoView>();

            return list;
        }



        public List<ProductoView> ProductoGet2(int ID_Producto, int num)
        {
            var context = new SIEPERU2Entities();
            var list = context.ProductoGet(ID_Producto).ToList().
                Select(obj => new ProductoView
                {
                    ID_Producto = obj.ID_Producto,
                    CostoProducto = obj.CostoProducto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    Estado = obj.Estado,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Codigo_UMedida = obj.Codigo_UMedida,
                    Cod_Lote = obj.Cod_Lote,
                    Precio_VenBase = obj.Precio_VenBase,
                    Precio_CompBase = obj.Precio_CompBase,
                    Precios = obj.Precios,
                    Fecha_venci = obj.Fecha_venci
                }).ToList<ProductoView>();

            return list;
        }


        public string ProductoDelete(int ID_Producto)
        {
            var context = new SIEPERU2Entities();
            context.ProductoDelete(ID_Producto);

            return "";
        }

        public Producto ProductoGet(int ID_Producto)
        {
            var context = new SIEPERU2Entities();
            var list = context.ProductoGet(ID_Producto).ToList().
                Select(obj => new Producto
                {
                    ID_Producto = obj.ID_Producto,
                    CostoProducto = obj.CostoProducto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    Estado = obj.Estado,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Codigo_UMedida = obj.Codigo_UMedida,
                    Cod_Lote = obj.Cod_Lote,
                    Precios = obj.Precios,
                    Fecha_venci = obj.Fecha_venci,
                   Precio_CompBase=obj.Precio_CompBase,
                   Precio_VenBase= obj.Precio_VenBase
                }).ToList<Producto>()[0];

            return list;
        }

        public List<ProductoView> ProductoBySocioList(string Descripcion, int ID_Categoria, int ID_SubCategoria, int ID_Socio)
        {

            var context = new SIEPERU2Entities();

            var list = context.ProductoBySocioList(Descripcion, ID_Categoria, ID_SubCategoria, ID_Socio).ToList().
                Select(obj => new ProductoView
                {
                    ID_Producto = obj.ID_Producto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    Estado = obj.Estado,
                    NombreEstado = obj.NombreEstado,
                  

                    ID_Precio = obj.ID_Precio,
                    Precios = obj.Precios,
                }).ToList<ProductoView>();

            return list;
        }



        public List<ProductoView> ProductoXalmacen(string Descripcion_Producto, int ID_Almacen, int ID_Sucursal)
        {

            var context = new SIEPERU2Entities();

            var list = context.ProductoXalmacen(Descripcion_Producto, ID_Almacen, ID_Sucursal).ToList().
                Select(obj => new ProductoView
                {
                    ID_Producto = obj.ID_Producto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    Fecha_venci = obj.Fecha_venci,
                    Sucursal = obj.Sucursal,
                    ID_Almacen = obj.ID_Almacen,
                    ID_Sucursal = obj.ID_Sucursal,
                    Lot = obj.Lot,
                    Cantida = obj.Cantida,              
                }).ToList<ProductoView>();

            return list;
        }

        public List<ProductoView> DetalleGrupoProductoAddList(string Descripcion_Producto, string ID_Marca, string ID_Categoria, string ID_SubCategoria)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleGrupoProductoAddList(Descripcion_Producto, ID_Marca, ID_Categoria, ID_SubCategoria).ToList().
                Select(obj => new ProductoView
                {
                    ID_Socio = obj.ID_Socio,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    Marca = obj.Marca,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Estado = obj.Estado
                }).ToList<ProductoView>();

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListaDeProducto { get; set; }
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaDeProducto = new List<Producto>();
        }
        public List<Producto> ObtenerProductos()
        {

            ListaDeProducto = _contexto.Productos
                .Include("Categoria")
                .OrderBy(r => r.Categoria.Descripcion)
                .ThenBy(r => r.Descripcion)
                .ToList();

            return ListaDeProducto; 
        }

        public List<Producto> ObtenerProductosActivos()
        {
            ListaDeProducto = _contexto.Productos
                .Include("Categoria")
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Descripcion)
                .ToList(); ;

            return ListaDeProducto;
        }

        //guardar producto
        public void GuardarProducto(Producto producto)
        {
            if(producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
               
                productoExistente.UrlImagen = producto.UrlImagen;

               
                productoExistente.Activo = producto.Activo;
            }
           
            _contexto.SaveChanges();
        }
        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Include("Categoria").FirstOrDefault(p => p.Id == id);
            return producto;
        }

       

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);

            _contexto.SaveChanges();
        }

    }
}

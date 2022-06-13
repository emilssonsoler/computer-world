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

            ListaDeProducto = _contexto.Productos.ToList();
            return ListaDeProducto; 
        }

        public void GuardarProducto(Producto producto)
        {
            _contexto.Productos.Add(producto);
            _contexto.SaveChanges();
        }

    }
}

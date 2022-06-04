using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class ProductosBL
    {

        public List<Producto> ObtenerProductos()
        {
            var producto = new Producto();
            producto.Id = 1;
            producto.Descripcion = "Computadora 1";
            producto.Precio = 100;
            

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Computadora 2";
            producto2.Precio = 200;
           


            var listaDeProductos = new List<Producto>();
            listaDeProductos.Add(producto);
            listaDeProductos.Add(producto2);
            return listaDeProductos;
        }
    }
}

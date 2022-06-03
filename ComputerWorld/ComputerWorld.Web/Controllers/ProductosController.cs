using ComputerWorld.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWorld.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto = new ProductoModel();
            producto.Id = 1;
            producto.Descripcion = "Computadora 1";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Computadora 2";

            var listaDeProductos = new List<ProductoModel>();
            listaDeProductos.Add(producto);
            listaDeProductos.Add(producto2);



            return View(listaDeProductos);
        }
    }
}
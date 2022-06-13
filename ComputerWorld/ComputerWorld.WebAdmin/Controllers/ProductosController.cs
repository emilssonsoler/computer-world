using ComputerWorld.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWorld.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Productos
        public ActionResult Index()
        {

            var listaDeProductos = _productosBL.ObtenerProductos();
            return View(listaDeProductos);
        }

        //HttpGet le mando al usuario, esta implicito
        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            return View(nuevoProducto);
        }

        //HttpPost el usuario manda de regreso
        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }
    }
}
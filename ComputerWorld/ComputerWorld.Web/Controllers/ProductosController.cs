using ComputerWorld.BL;
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
            var productoBL = new ProductosBL();
            var listaDeProductos = productoBL.ObtenerProductos();
  
            return View(listaDeProductos);
        }
    }
}
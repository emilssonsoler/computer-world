using ComputerWorld.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWorld.WebAdmin.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
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
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
            return View(nuevoProducto);
        }

        //HttpPost el usuario manda de regreso y guarda los cambios
        [HttpPost]
        public ActionResult Crear(Producto producto, HttpPostedFileBase imagen)
        {

            if (ModelState.IsValid)
            {
                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Seleccione un categoria"); 
                     return View(producto);
                }

                if (imagen != null)
                {
                    producto.UrlImagen = GuardarImagen(imagen);
                }
                _productosBL.GuardarProducto(producto);

                return RedirectToAction("Index");
            }
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
            return View(producto);
            
        }

        //buscamos un id de producto y lo mandamos a la vista
        public ActionResult Editar(int id) {

            var producto = _productosBL.ObtenerProducto(id); ;
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId =
                 new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto); 
        }

        //guarda los cambios hechos de la vista editar
        [HttpPost]
        public ActionResult Editar(Producto producto, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Seleccione un categoria");
                    return View(producto);
                }
                if (imagen != null)
                {
                    producto.UrlImagen = GuardarImagen(imagen);
                }
                _productosBL.GuardarProducto(producto);

                return RedirectToAction("Index");
            }
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
            return View(producto);
        }

        // muestra los detalles del producto
        public ActionResult Detalle(int id)
        {
           
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }

        //Mandamos la informacion del producto que queremos eliminar
        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }


        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }

        //Guardar imagen
        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return ("/Imagenes/" + imagen.FileName);
        }


    }
}
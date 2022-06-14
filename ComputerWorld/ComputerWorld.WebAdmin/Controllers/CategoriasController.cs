using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComputerWorld.BL;

namespace ComputerWorld.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {

        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Categorias
        public ActionResult Index()
        {
            var listaDeCategorias = _categoriasBL.ObtenerCategorias();
            return View(listaDeCategorias);
        }

        //HttpGet le mando al usuario, esta implicito
        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();
            return View(nuevaCategoria);
        }

        //HttpPost el usuario manda de regreso y guarda los cambios
        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
            _categoriasBL.GuardarCategoria(categoria);

            return RedirectToAction("Index");
        }

        //buscamos un id de categoria y lo mandamos a la vista
        public ActionResult Editar(int id)
        {

            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        //guarda los cambios hechos de la vista editar
        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            _categoriasBL.GuardarCategoria(categoria);
            return RedirectToAction("Index");
        }

        // muestra los detalles de la categoria
        public ActionResult Detalle(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        //Mandamos la informacion del producto que queremos eliminar
        public ActionResult Eliminar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        //Aplicamos los cambios
        [HttpPost]
        public ActionResult Eliminar(Categoria categoria)
        {
            _categoriasBL.EliminarCategoria(categoria.Id);
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class CategoriasBL
    {
        Contexto _contexto;
        public List<Categoria> ListaDeCategorias { get; set; }


        //Constructor
        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListaDeCategorias = new List<Categoria>();
        }

        //Obtener la lista de Categoria
        public List<Categoria> ObtenerCategorias()
        {

            ListaDeCategorias = _contexto.Categorias.ToList();
            return ListaDeCategorias;
        }

        //Guardar Categoria
        public void GuardarCategoria(Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                _contexto.Categorias.Add(categoria);
            }
            else
            {
                var categoriaExistente = _contexto.Productos.Find(categoria.Id);
                categoriaExistente.Descripcion = categoria.Descripcion;
                
            }

            _contexto.SaveChanges();
        }

        //Obtener categoria
        public Categoria ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            return categoria;
        }


        //Eliminar Categoria
        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);

            _contexto.SaveChanges();
        }

    }
}

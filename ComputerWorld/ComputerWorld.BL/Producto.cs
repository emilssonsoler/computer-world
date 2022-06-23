using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la descripcion")]
        [MinLength (3,ErrorMessage ="Ingrese minimo 3 caracteres")]
        [MaxLength(20,ErrorMessage ="Ingrese maximo 20 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0,100000,ErrorMessage ="El rango del precio debe estar entre 0 a 100,000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name ="Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }

    }
}

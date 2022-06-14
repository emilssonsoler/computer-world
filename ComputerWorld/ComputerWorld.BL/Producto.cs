using System;
using System.Collections.Generic;
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
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Producto Categoria { get; set; }
        public bool Activo { get; set; }

    }
}

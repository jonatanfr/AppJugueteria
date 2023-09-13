using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJugueteria
{
    public class Producto
    {
        private int id { get; set; }
        private string descripcion { get; set; }
        private float costo { get; set; }
        private float precioVenta { get; set; }
        private int stock { get; set; }
        private int idUsuario { get; set; }
    }
}

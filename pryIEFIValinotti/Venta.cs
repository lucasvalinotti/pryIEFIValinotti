using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryIEFIValinotti
{
    public class Venta
    {
        public int ID { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
    }
}

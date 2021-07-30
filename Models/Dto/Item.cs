using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Models.Dto
{
    public class Item
    {
        public char NumPedido { get; set; }
        public char Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public char Vendedor { get; set; }
       

    }
}

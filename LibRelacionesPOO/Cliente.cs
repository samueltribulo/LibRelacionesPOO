using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO
{
    public class Cliente
    {

        public string Nombre { get; set; }

        public Usuario Usuario { get; set;}

        public List<Pedido> Pedidos { get; set; }



    }
}

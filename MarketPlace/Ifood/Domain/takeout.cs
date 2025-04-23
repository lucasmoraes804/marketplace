using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class takeout
    {
        /// <summary>
        ///	Modo de retirada: <br/>
        /// <b>DEFAULT</b> (cliente retira o pedido no balcão) <br/>
        /// <b>PICKUP_AREA</b> (cliente vai esperar o pedido em uma vaga especial do estacionamento)
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// Data e hora da retirada do pedido
        /// </summary>
        public string takeoutDateTime { get; set; }
        /// <summary>
        /// Observações sobre a retirada do pedido
        /// </summary>
        public string observations { get; set; }
    }
}

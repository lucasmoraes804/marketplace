using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class indoor
    {
        /// <summary>
        /// Modo de retirada: <br/>
        /// <b>DEFAULT</b> (cliente retira o pedido no balcão) <br/>
        /// <b>TABLE</b> (cliente vai esperar o pedido em uma mesa do estabelecimento)
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// Número ou código da mesa onde o cliente fez o pedido (somente quando mode = TABLE)
        /// </summary>
        public string table { get; set; }
        /// <summary>
        /// Data e hora da entrega ou retirada do pedido
        /// </summary>
        public string deliveryDateTime { get; set; }
        /// <summary>
        /// Observações sobre a retirada do pedido
        /// </summary>
        public string observations { get; set; }
    }
}

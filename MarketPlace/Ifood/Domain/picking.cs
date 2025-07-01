using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class picking
    {
        /// <summary>
        /// Responsável pela separação dos itens do pedido (Ex: DRIVER_SHOPPER). <br/>
        /// Quando não informado, o próprio merchant é responsável pela separação dos itens e preparo do pedido.
        /// </summary>
        public string picker { get; set; }
        /// <summary>
        /// Opções para substituir um item em caso de ruptura <br/>
        /// (Ex: STORE_CHOOSE_OTHER_ITEMS / STORE_CONTACT_CUSTOMER / STORE_CANCEL_ORDER / STORE_REMOVE_ITEMS)
        /// </summary>
        public string replacementOptions { get; set; }
    }
}

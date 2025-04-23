using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class orderMerchant
    {
        /// <summary>
        /// identificador único do merchant (loja)
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// nome do merchant (loja)
        /// </summary>
        public string name { get; set; }     
    }
}

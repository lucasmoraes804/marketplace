using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class total
    {
        /// <summary>
        /// Somatório do valor dos itens
        /// </summary>
        public decimal subTotal { get; set; }
        /// <summary>
        /// Valor da taxa de entrega
        /// </summary>
        public decimal deliveryFee { get; set; }
        /// <summary>
        /// Somatório dos benefits (cupons de desconto)
        /// </summary>
        public decimal benefits { get; set; }
        /// <summary>
        /// Somatório das taxas adicionais
        /// </summary>
        public decimal additionalFees { get; set; }
        /// <summary>
        /// Valor total do pedido (orderAmount = subTotal + deliveryFee + additionalFees - benefits)
        /// </summary>
        public decimal orderAmount { get; set; }
    }
}

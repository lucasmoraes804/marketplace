using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class customer
    {
        /// <summary>
        /// Identificador único do cliente
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Número do documento do cliente (cpf) que deve ser utilizado somente para
        /// emissão de documento fiscal quando o cliente solicitar, pois o campo é opcional.
        /// </summary>
        public string documentNumber { get; set; }
        /// <summary>
        /// Quantidade de pedidos já feito por esse cliente nessa loja. Campo opcional (eventualmente pode ser nulo).
        /// </summary>
        public int? ordersCountOnMerchant { get; set; }
        public customer_phone phone { get; set; }
        /// <summary>
        /// Classificação do cliente quanto à Super-Segmentação <br/>
        /// (Explorer, Bronze, Silver, Gold, Platinum). <br/>
        /// Campo opcional. Eventualmente pode não ser retornado.
        /// </summary>
        public string segmentation { get; set; }
    }

    public class customer_phone
    {
        /// <summary>
        /// Número de telefone do cliente ou do 0800 fornecido pelo iFood
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// Código localizador que deve ser informado ao ligar para o número 0800
        /// </summary>
        public string localizer { get; set; }
        /// <summary>
        /// Data de expiração do localizador do 0800
        /// </summary>
        public string localizerExpiration { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class order
    {
        public order()
        {
            items = new List<item>();
            benefits = new List<benefits>();
            additionalFees = new List<additionalFees>();
        }

        /// <summary>
        /// Identificador único do pedido
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Id amigável para facilitar a identificação do pedido pela loja. Deve ser exibido na interface do seu aplicativo.
        /// </summary>
        public string displayId { get; set; }
        /// <summary>
        /// tipo de pedido
        /// </summary>
        public string orderType { get; set; }
        /// <summary>
        /// momento de entrega do pedido
        /// </summary>
        public string orderTiming { get; set; }
        /// <summary>
        /// Canal de vendas pelo qual o pedido entra na plataforma (novos canais podem ser adicionados).
        /// Possíveis valores: IFOOD, DIGITAL_CATALOG, POS, ECONOMIC, TOTEM, IFOOD_SHOP, IFOOD_APP, IFOOD_SITE, WAITER, PDV,
        /// QR_CODE, IFOOD_SHOP_APP, IFOOD_SHOP_SITE, GROCERY_WHITELABEL_SITE
        /// </summary>
        public string salesChannel { get; set; }
        /// <summary>
        /// categoria do pedido (FOOD, GROCERY, ANOTAI)
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// data de criação do pedido
        /// </summary>
        public string createdAt { get; set; }
        /// <summary>
        /// recomendação de início do preparo do pedido
        /// </summary>
        public string preparationStartDateTime { get; set; }
        /// <summary>
        /// indica se é um pedido de teste ou não
        /// </summary>
        public bool isTest { get; set; }
        /// <summary>
        /// informações adicionais sobre o pedido
        /// </summary>
        public string extraInfo { get; set; }
        
        public orderMerchant merchant { get; set; }
        public payment payments { get; set; }
        public customer customer { get; set; }
        public List<item> items { get; set; }
        public total total { get; set; }
        public delivery delivery { get; set; }
        public List<benefits> benefits { get; set; }
        public List<additionalFees> additionalFees { get; set; }
        public picking picking { get; set; }
        public schedule schedule { get; set; }
        public dineIn dineIn { get; set; }
        public indoor indoor { get; set; }
        public takeout takeout { get; set; }
    }
}

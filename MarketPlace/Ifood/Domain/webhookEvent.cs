using System;

namespace Ifood.Domain
{
    public class webhookEvent
    {
        /// <summary>
        /// id único do evento
        /// </summary>
        public Guid id { get; set; }
        
        /// <summary>
        /// 	código do evento
        /// </summary>
        public string code { get; set; }
        
        /// <summary>
        /// código completo do evento (nome)
        /// </summary>
        public string fullCode { get; set; }
        
        /// <summary>
        /// pedido ao qual esse evento está vinculado
        /// </summary>
        public Guid orderId { get; set; }
        
        /// <summary>
        /// id do merchant do pedido
        /// </summary>
        public Guid merchantId { get; set; }
        
        /// <summary>
        /// data de criação do event
        /// </summary>
        public DateTime createdAt { get; set; }
        
        /// <summary>
        /// Canal de vendas pelo qual o pedido entra na plataforma (novos canais podem ser adicionados).
        /// Possíveis valores: IFOOD, DIGITAL_CATALOG, POS, ECONOMIC, TOTEM, IFOOD_SHOP, IFOOD_APP, IFOOD_SITE,
        /// WAITER, PDV, QR_CODE, IFOOD_SHOP_APP, IFOOD_SHOP_SITE, GROCERY_WHITELABEL_SITE
        /// </summary>
        public string salesChannel { get; set; }
    }
}
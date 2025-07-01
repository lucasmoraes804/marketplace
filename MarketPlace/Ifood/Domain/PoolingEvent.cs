using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class poolingEvent
    {
        /// <summary>
        /// id único do evento
        /// </summary>
        public string id { get; set; }
        
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
        public string orderId { get; set; }
        
        /// <summary>
        /// id do merchant do pedido
        /// </summary>
        public string merchantId { get; set; }
        
        /// <summary>
        /// data de criação do event
        /// </summary>
        public string createdAt { get; set; }
        
        /// <summary>
        /// Canal de vendas pelo qual o pedido entra na plataforma (novos canais podem ser adicionados).
        /// Possíveis valores: IFOOD, DIGITAL_CATALOG, POS, ECONOMIC, TOTEM, IFOOD_SHOP, IFOOD_APP, IFOOD_SITE,
        /// WAITER, PDV, QR_CODE, IFOOD_SHOP_APP, IFOOD_SHOP_SITE, GROCERY_WHITELABEL_SITE
        /// </summary>
        public string salesChannel { get; set; }

        /// <summary>
        /// Informações adicionais do evento
        /// </summary>
        public JsonDocument metadata { get; set; }
    }

    public static class PoolingEventStatusCode
    {
        public const string PLACED = "PLACED";         //Indica um pedido foi colocado no sistema.
        public const string INTEGRATED = "INTEGRATED"; //Indica um pedido que foi recebido pelo e-PDV.
        public const string CONFIRMED = "CONFIRMED";   //Indica um pedido confirmado.
        public const string CANCELLED = "CANCELLED";   //Indica um pedido que foi cancelado.
        public const string CANCELLATION_REQUEST_FAILED = "CANCELLATION_REQUEST_FAILED ";   //em caso de falha no cancelamento.
        public const string DISPATCHED = "DISPATCHED"; //Indica um pedido que foi despachado ao cliente.
        public const string DELIVERED = "DELIVERED";   //Indica um pedido que foi entregue.
        public const string CONCLUDED = "CONCLUDED";   //Indica um pedido que foi concluído (Em até duas horas do fluxo normal)*.
    }

    public static class PoolingEventStatusCode_VERSAO_2
    {
        public const string PLACED = "PLC";

    }
}

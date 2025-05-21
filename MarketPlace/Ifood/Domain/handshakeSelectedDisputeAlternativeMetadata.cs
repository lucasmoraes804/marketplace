using System.Collections.Generic;

namespace Ifood.Domain
{
    public class handshakeSelectedDisputeAlternativeMetadata
    {
        /// <summary>
        /// Valor monetário enviado na contraproposta. <br/>
        /// Por exemplo durante a execução do fluxo de Proposta de Reembolso,
        /// quando o parceiro envia um valor monetário de até 80%do valor do pedido para evitar o cancelamento.
        /// </summary>
        public handshakeAmount amount { get; set; }
        /// <summary>
        /// Valor numérico indicando quanto tempo a mais o parceiro precisa para entregar o pedido.<br/>
        /// Por exemplo durante a execução do fluxo de negociação de atraso,
        /// quando o parceiro tem a opção de pedir que o cliente espere por mais X minutos para o pedido ser entregue.
        /// </summary>
        public short additionalTimeInMinutes { get; set; }
        /// <summary>
        /// Motivo do atraso na entrega do pedido que a loja deve informar quando quiser negociar um novo tempo de entrega.
        /// </summary>
        public string additionalTimeReason { get; set; }
    }
}
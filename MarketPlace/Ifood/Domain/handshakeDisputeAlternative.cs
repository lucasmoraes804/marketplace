namespace Ifood.Domain
{
    public class handshakeDisputeAlternative
    {
        /// <summary>
        /// Id da DisputeAlternative que deve ser utilizada para responder uma determinada Dispute. <br/>
        /// Por exemplo durante a execução do fluxo de Proposta de Reembolso.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Ação que pode ser executada após a finalização da negociação. REFUND, BENEFIT ou ADDITIONAL_TIME
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Valor monetário máximo possível para ser enviado na resposta de uma determinada Dispute. <br/>
        /// Por exemplo durante a execução do fluxo de Proposta de Reembolso,
        /// quando o parceiro tem a opção de enviar um valor monetário de até 80% do valor do pedido para evitar o cancelamento
        /// </summary>
        public handshakeAmount maxAmount { get; set; }

        public handshakeDisputeAlternativeMetadata metadata { get; set; }
    }
}
namespace Ifood.Domain
{
    public class handshakeSettlement
    {
        /// <summary>
        /// Id do Settlement gerado
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Id da Dispute
        /// </summary>
        public string disputeId { get; set; }
        /// <summary>
        /// Representa o resultado final da negociação relacionada a uma Dispute (disputeId) ACCEPTED, REJECTED, EXPIRED ou ALTERNATIVE_REPLIED
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// Representa a justificativa de rejeição ou aceite de uma determinada negociação. <br/>
        /// Em casos de Disputes relacionadas à solicitação de cancelamento, o campo é obrigatório quando o status for REJECTED.
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// Representa os dados enviados durante a resposta de uma Dispute com status ALTERNATIVE_REPLIED. <br/>
        /// Por exemplo durante a execução do fluxo de Proposta de Reembolso.
        /// </summary>
        public handshakeSelectedDisputeAlternative selectedDisputeAlternative { get; set; }
    }
}
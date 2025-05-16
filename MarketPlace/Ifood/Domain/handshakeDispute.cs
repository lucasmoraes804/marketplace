using System.Collections.Generic;

namespace Ifood.Domain
{
    public class handshakeDispute
    {
        /// <summary>
        /// Id da Dispute
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Id da Dispute que originou uma contraproposta Por exemplo, no fluxo de Proposta de Reembolso
        /// </summary>
        public string parentDisputeId { get; set; }
        /// <summary>
        /// Ação que a Dispute representa, qual o objetivo da negociação.<br/> CANCELLATION, PARTIAL_CANCELLATION, PROPOSED_AMOUNT_REFUND, PROPOSED_ADDITIONAL_TIME ou VOID
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// Mensagem associada à razão da Dispute (negociação). <br/>
        /// Para os fluxos de cancelamento, representa a justificativa de cancelamento informada pelo consumidor
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// Respostas alternativas que estão disponíveis, além do aceite/rejeite da Dispute.<br/>
        /// Contém as informações que podem ser enviadas no fluxo de proposta de reembolso, por exemplo.
        /// </summary>
        public List<handshakeDisputeAlternative> alternatives { get; set; }
        /// <summary>
        /// Tempo máximo para que a negociação seja respondida antes que a ação automática seja disparada automaticamente.
        /// </summary>
        public string expiresAt { get; set; }
        /// <summary>
        /// Data e Hora de criação da Dispute
        /// </summary>
        public string createdAt { get; set; }
        /// <summary>
        /// Tipo da negociação que foi iniciada. AFTER_DELIVERY, DELAY, PREPARATION_TIME ou AFTER_DELIVERY_PARTIALLY
        /// </summary>
        public string handshakeType { get; set; }
        /// <summary>
        /// Agrupamento do handshake. CUSTOMER_ORDER_SUPPORT
        /// </summary>
        public string handshakeGroup { get; set; }
        /// <summary>
        /// Ação automática a ser executada caso o Handshake não seja respondido dentro do prazo determinado pelo expiresAt. <br/>
        /// ACCEPT_CANCELLATION, REJECT_CANCELLATION ou VOID
        /// </summary>
        public string timeoutAction { get; set; }
        public handshakeDisputeMetadata metadata { get; set; }
    }
}
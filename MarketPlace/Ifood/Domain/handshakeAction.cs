namespace Ifood.Domain
{
    public class handshakeAction
    {
        /// <summary>
        /// Id da ação
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Status da ação (Valores aceitos: ACCEPTED / REJECTED / ALTERNATIVE_REPLIED)
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// Justificativa de recusa da negociação.
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// ID da disputa criada
        /// </summary>
        public string disputeId { get; set; }
        /// <summary>
        /// Data da criação da ação
        /// </summary>
        public string createdAt { get; set; }
    }
}
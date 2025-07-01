namespace Ifood.Domain
{
    public class handshakeSelectedDisputeAlternative
    {
        /// <summary>
        ///	Id da DisputeAlternative selecionada da Dispute com opções de contraproposta.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Tipo da DisputeAlternative selecionada durante a resposta da Dispute. REFUND ou BENEFIT
        /// </summary>
        public string type { get; set; }
        public handshakeSelectedDisputeAlternativeMetadata metadata { get; set; }
    }
}
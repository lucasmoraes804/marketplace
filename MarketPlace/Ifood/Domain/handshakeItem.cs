namespace Ifood.Domain
{
    public class handshakeItem
    {
        /// <summary>
        /// Id do catálogo
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Id único do item na order
        /// </summary>
        public string uniqueId { get; set; }
        /// <summary>
        /// Id do item na integradora
        /// </summary>
        public string integrationId { get; set; }
        /// <summary>
        /// Quantidade de itens
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// Index na bag
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// Valor unitário do item
        /// </summary>
        public handshakeAmount amount { get; set; }
        /// <summary>
        /// Justificativa do consumidor para cancelar o item em questão. <br/> Por exemplo: Produto chegou diferente do solicitado.
        /// </summary>
        public string reason { get; set; }
    }
}
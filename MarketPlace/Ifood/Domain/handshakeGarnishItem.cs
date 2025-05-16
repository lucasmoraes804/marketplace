namespace Ifood.Domain
{
    public class handshakeGarnishItem
    {
        /// <summary>
        /// Id do catálogo
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Unique id do item pai
        /// </summary>
        public string parentUniqueId { get; set; }
        /// <summary>
        /// Id do garnish item na integradora
        /// </summary>
        public string externalCode { get; set; }
        /// <summary>
        /// Quantidade de garnishItems que estão sendo cancelados
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// Index na bag
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// Valor unitário do garnish item
        /// </summary>
        public handshakeAmount amount { get; set; }
        /// <summary>
        /// Justificativa do consumidor para cancelar o item em questão. <br/> Por exemplo: Não chegou o refrigerante do combo.
        /// </summary>
        public string reason { get; set; }
    }
}
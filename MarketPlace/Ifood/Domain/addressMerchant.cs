namespace Ifood.Domain
{
    public class addressMerchant
    {
        /// <summary>
        /// Sigla do país
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Sigla da unidade federativa
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// Nome da cidade
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Código postal
        /// </summary>
        public string postalCode { get; set; }

        /// <summary>
        /// Nome do Bairro
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// Nome da rua com número e bairro
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Nùmero do estabelecimento
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Latitude do estabelecimento
        /// </summary>
        public decimal latitude { get; set; }

        /// <summary>
        /// Longitude do estabelecimento
        /// </summary>
        public decimal longitude { get; set; }
    }
}
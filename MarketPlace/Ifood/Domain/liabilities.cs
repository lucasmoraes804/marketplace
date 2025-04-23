namespace Ifood.Domain
{
    public class liabilities
    {
        /// <summary>
        /// Responsável por pagar a taxa
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Porcentagem que o responsável correspondente deve pagar
        /// </summary>
        public decimal percentage { get; set; }
    }
}
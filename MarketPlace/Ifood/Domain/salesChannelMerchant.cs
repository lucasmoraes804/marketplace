using Ifood.Enum;

namespace Ifood.Domain
{
    public class salesChannelMerchant
    {
        /// <summary>
        /// <see cref="MerchantSalesChannel">Nome</see> do canal de vendas.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Indica se o canal de vendas está ativo ou não.
        /// </summary>
        public bool enabled { get; set; }
    }
}
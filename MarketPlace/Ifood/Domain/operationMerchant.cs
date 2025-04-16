using System.Collections.Generic;
using Ifood.Enum;

namespace Ifood.Domain
{
    public class operationMerchant
    {
        /// <summary>
        /// <see cref="MerchantOperation">Nome</see> da operação
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Informações sobre o canal de vendas da loja
        /// </summary>
        public List<salesChannelMerchant> salesChannels { get; set; }
    }
}
using System.Collections.Generic;
using Ifood.Enum;

namespace Ifood.Domain
{
    public class merchant
    {
        /// <summary>
        /// Identificador único da loja.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Nome público da loja. (Nome fantasia)
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Nome jurídico da loja. (Razão social)
        /// </summary>
        public string corporateName { get; set; }

        /// <summary>
        /// Descrição da loja.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Ticket médio da loja.
        /// </summary>
        public decimal averageTicket { get; set; }

        /// <summary>
        /// Indica se a loja opera exclusivamente com o iFood.
        /// </summary>
        public bool exclusive { get; set; }

        /// <summary>
        /// <see cref="MerchantType">Tipo</see> da loja.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// <see cref="MerchantStatus">Disponibilidade</see> da loja.
        /// </summary>
        public string status { get; set; }
        
        /// <summary>
        /// Data de criação da loja.
        /// </summary>
        public string createdAt { get; set; }

        /// <summary>
        /// Informações de endereço da loja.
        /// </summary>
        public addressMerchant address { get; set; }

        /// <summary>
        /// Informações sobre as operações da loja.
        /// </summary>
        public List<operationMerchant> operations { get; set; }
    }
}
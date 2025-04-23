using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class benefits
    {
        public benefits()
        {
            sponsorshipValues = new List<sponsorshipValues>();
        }

        /// <summary>
        /// Valor do desconto/incentivo
        /// </summary>
        public decimal value { get; set; }
        /// <summary>
        /// Informação sobre onde o desconto será aplicado.
        /// </summary>
        public string target { get; set; }
        /// <summary>
        /// Index do item (items.index) sobre o qual o desconto deve ser aplicado. <br/>
        /// Somente para os casos em que o target é do tipo ITEM ou PROGRESSIVE_DISCOUNT_ITEM
        /// </summary>
        public string targetId { get; set; }
        public List<sponsorshipValues> sponsorshipValues { get; set; }       
        public campaign campaign { get; set; }
    }

    public class sponsorshipValues
    {
        /// <summary>
        /// Nome do patrocinador desse benefício
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Valor subsidiado pelo patrocinador
        /// </summary>
        public decimal value { get; set; }
        /// <summary>
        /// Descrição do patrocinador do desconto para ser exibido no aplicativo ou na comanda impressa
        /// </summary>
        public string description { get; set; }
    }

    public class campaign
    {
        /// <summary>
        /// Identificador único da campanha do respectivo benefício
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Nome da campanha do respectivo benefício
        /// </summary>
        public string name { get; set; }
    }
}

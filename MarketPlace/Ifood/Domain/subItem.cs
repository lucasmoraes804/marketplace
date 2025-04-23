using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class subItem
    {
        public subItem()
        {
            customization = new List<subItemCustomization>();
        }
        
        /// <summary>
        /// Posição/ordem dos complementos
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// Identificador único do complemento
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Nome do complemento
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Nome grupo do complemento
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// Tipo do complemento
        /// </summary>
        public string type { get; set; }
        /// <summary>
        ///	Código do complemento no seu aplicativo (codPDV). É opcional e pode ser configurado no catálogo
        /// </summary>
        public string externalCode { get; set; }
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public decimal quantity { get; set; }
        /// <summary>
        /// Unidade do item (Ex: UN, g, Kg, ml, L)
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// Preço unitário
        /// </summary>
        public decimal unitPrice { get; set; }
        /// <summary>
        /// Valor adicional que pode ser incluído no valor do complemento. <br/>
        /// (Ex: Para pizzas com mais de um sabor, é possível configurar o catálogo para que seja cobrado o valor do sabor de maior valor. <br/>
        /// Nesses casos essa é a diferença entre o valor original do sabor de menor valor e o sabor de maior valor).
        /// </summary>
        public decimal addition { get; set; }
        /// <summary>
        /// Preço do complemento: price = quantity x (unitPrice + addition)
        /// </summary>
        public decimal price { get; set; }

        public List<subItemCustomization> customization { get; set; }
        //public decimal totalPrice { get; set; }
        //public decimal discount { get; set; }
        //public string observations { get; set; }
    }
}

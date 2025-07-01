using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class item
    {
        public item()
        {
            options = new List<subItem>();
        }

        /// <summary>
        /// Posição/ordem dos itens
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// Identificador único do item no catálogo
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Identificador único do item no pedido (necessário, uma vez que o mesmo item pode aparecer várias vezes no pedido)
        /// </summary>
        public string uniqueId { get; set; }
        /// <summary>
        /// Url da imagem/foto do item. Quando disponível, a URL retorna, por padrão, uma imagem na qualidade high. <br/>
        /// É possível alterar o path dessa imagem para obter a imagem em outras qualidades.
        /// </summary>
        public string imageUrl { get; set; }
        /// <summary>
        /// Código do item no seu aplicativo (codPDV). É opcional e pode ser configurado no catálogo
        /// </summary>
        public string externalCode { get; set; }
        /// <summary>
        /// Código de barras (European Article Number)
        /// </summary>
        public string ean { get; set; }
        /// <summary>
        /// Nome do item
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Tipo do item
        /// </summary>
        public string type { get; set; }
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
        /// Preço do item: price = quantity x (unitPrice + addition)
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// Preço dos complementos (options)
        /// </summary>
        public decimal optionsPrice { get; set; }       
        /// <summary>
        /// Preço total incluindo os complementos (totalPrice = price + optionsPrice)
        /// </summary>
        public decimal totalPrice { get; set; }
        //public decimal addition { get; set; }

        //public decimal discount { get; set; }
        /// <summary>
        /// Observações do pedido. (Ex: "Retirar cebola") Tamanho máximo: 1024 caracteres
        /// </summary>
        public string observations { get; set; }

        public List<subItem> options { get; set; }
        public item_scalePrices scalePrices { get; set; }
    }

    public class item_scalePrices
    {
        public item_scalePrices()
        {
            scales = new List<item_scalePrices_scales>();
        }

        /// <summary>
        /// Preço padrão do item sem alteração
        /// </summary>
        public decimal defaultPrice { get; set; }
        /// <summary>
        /// Lista contendo informações de quantidades e preços para venda em atacado
        /// </summary>
        public List<item_scalePrices_scales> scales { get; set; }
    }

    public class item_scalePrices_scales
    {
        /// <summary>
        /// Preço do item com desconto em atacado
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// Quantidade mínima de itens para aplicar desconto
        /// </summary>
        public decimal minQuantity { get; set; }
    }
}

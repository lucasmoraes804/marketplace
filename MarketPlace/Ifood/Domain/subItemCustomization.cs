namespace Ifood.Domain
{
    public class subItemCustomization
    {
        /// <summary>
        /// Identificador único do terceiro nível de complemento
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Nome do item do terceiro nível de complemento
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Nome do Grupo do terceiro nível de complemento
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// Código do item do terceiro nível de complemento no seu aplicativo (codPDV). <br/>
        /// É opcional e pode ser configurado no catálogo
        /// </summary>
        public string externalCode { get; set; }
        /// <summary>
        /// Tipo do terceiro nível de complemento
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Quantidade do item do terceiro nível de complemento
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// Preço unitário
        /// </summary>
        public decimal unitPrice { get; set; }
        /// <summary>
        /// Valor adicional que pode ser incluído no valor do terceiro nível de complemento. <br/>
        /// (Ex: Para pizzas com mais de um sabor, é possível configurar o catálogo para que seja cobrado o valor do sabor de maior valor. <br/>
        /// Nesses casos essa é a diferença entre o valor original do sabor de menor valor e o sabor de maior valor).
        /// </summary>
        public decimal addition { get; set; }
        /// <summary>
        /// Preço total do item do terceiro nível de complemento: price = quantity x (unitPrice + addition)
        /// </summary>
        public decimal price { get; set; }
    }
}
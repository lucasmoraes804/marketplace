namespace Ifood.Domain
{
    public class handshakeAmount
    {
        /// <summary>
        /// Valor monetário inserido sem casas decimais baseado na currency.<br/> Por exemplo: R$ 0, 99 = 99 R$ 1, 00 = 100 R$ 13, 99 = 1399
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// Unidade monetária utilizada.<br/>  Para pedidos realizados em Real o valor enviado é BRL
        /// </summary>
        public string currency { get; set; }
    }
}
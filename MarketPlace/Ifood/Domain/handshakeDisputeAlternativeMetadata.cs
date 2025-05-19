using System.Collections.Generic;

namespace Ifood.Domain
{
    public class handshakeDisputeAlternativeMetadata
    {
        /// <summary>
        /// Lista com valores numéricos que o parceiro possa escolher quanto tempo a mais ele precisa para entregar o pedido. <br/>
        /// Por exemplo durante a execução do fluxo de negociação de atraso,
        /// quando o parceiro tem a opção de pedir que o cliente espere por mais X minutos para o pedido ser entregue.
        /// </summary>
        public List<short> allowedsAdditionalTimeInMinutes { get; set; }
        /// <summary>
        /// Lista de motivos do atraso na entrega do pedido que a loja deve informar quando quiser negociar um novo tempo de entrega.
        /// </summary>
        public List<string> allowedsAdditionalTimeReasons { get; set; }
    }
}
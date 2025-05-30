using System.Collections.Generic;

namespace Ifood.Domain
{
    public class merchantStatus
    {
        /// <summary>
        /// Processo/Atividade que a loja executa <br/><br/>
        /// <b>DELIVERY</b> - Pedidos que devem ser enviados ao endereço do cliente imediatamente após o preparo. <br/>
        /// <b>TAKEOUT</b>  - Pedidos que o próprio cliente faz a retirada na loja. <br/>
        /// <b>INDOOR</b> - Pedidos que serão consumidos na própria loja.
        /// O cliente pode retirar o pedido no balcão ou recebê-lo em uma das mesas (obs: serviço indisponível no momento).
        /// </summary>
        public string operation { get; set; }
        /// <summary>
        /// Recurso utilizado pelo cliente para realizar um pedido a uma loja. <br/><br/>
        /// <b>Marketplace iFood</b> - O aplicativo e website pelos quais é possível navegar pelas diferentes lojas presentes no iFood. <br/>
        /// <b>WhatsApp</b> - A utilização do WhatsApp como canal para receber pedidos iFood. <br/>
        /// <b>Cardápio Digital</b> - O Cardápio Digital é uma ferramenta em que o iFood auxilia a loja a ter seu próprio catálogo. <br/>
        /// <b>Totem</b> - O Totem utiliza dispositivos interativos em que é possível navegar pelo cardápio e fazer pedidos iFood.
        /// </summary>
        public string salesChannel { get; set; }
        /// <summary>
        /// Indica se a loja está disponível
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// Estado atual da loja. <br/><br/>
        /// <b>OK</b> - Indica que a loja está online. <br/>
        /// <b>WARNING</b> - Indica que a loja está online, mas podem haver restrições como redução de área de entrega. <br/>
        /// <b>CLOSED</b> - Indica que a loja está fechada conforme esperado, como em casos de "fora do horário de funcionamento" ou "em pausa programada". Não requer nenhuma ação. <br/>
        /// <b>ERROR</b> - Indica que a loja está fechada por algum motivo não esperado. Requer uma ação da loja.
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// Informações sobre reabertura da loja. <br/>
        /// </summary>
        public merchantReopenable reopenable { get; set; }
        /// <summary>
        /// Validações da loja
        /// </summary>
        public List<merchantValidation> validations { get; set; }
        /// <summary>
        /// Mensagem do status
        /// </summary>
        public merchantMessage message { get; set; }
    }
}
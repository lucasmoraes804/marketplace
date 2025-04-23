using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class delivery
    {
        /// <summary>
        /// Códigos para controles internos do iFood. <br/>
        /// Valores possíveis: DEFAULT / EXPRESS / HIGH_DENSITY / TURBO/PRIORITY
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// Tipo de entrega solicitado pelo cliente. <br/> Valores possíveis: Padrão / Rápida / Expressa. <br/><br/>
        /// <b>Padrão:</b> Entrega padrão do iFood;<br/>
        /// <b>Rápida:</b> Entrega 20% mais rápida que a Padrão, com custo variável <br/>
        /// <b>Expressa:</b> Entrega em até 30 minutos, com custo fixo
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Responsável por fazer a entrega: IFOOD (logística iFood) ou MERCHANT (entrega própria)
        /// </summary>
        public string deliveredBy { get; set; }
        /// <summary>
        /// Código de segurança para conferir com o código informado pelo entregador no momento da coleta do pedido
        /// </summary>
        public string pickupCode { get; set; }
        /// <summary>
        /// Data e horário da entrega
        /// </summary>
        public string deliveryDateTime { get; set; }
        /// <summary>
        /// Observações sobre a entrega (Ex: "Não tem porteiro. Favor interfonar.")
        /// </summary>
        public string observations { get; set; }
        /// <summary>
        /// Endereço onde o pedido deve ser entregue
        /// </summary>
        public deliveryAddress deliveryAddress { get; set; }
    }
}

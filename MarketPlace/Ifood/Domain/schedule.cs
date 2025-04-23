using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class schedule
    {
        /// <summary>
        /// Início do horário (intervalo) agendado
        /// </summary>
        public string deliveryDateTimeStart { get; set; }
        /// <summary>
        /// Fim do horário (intervalo) agendado
        /// </summary>
        public string deliveryDateTimeEnd { get; set; }
    }
}

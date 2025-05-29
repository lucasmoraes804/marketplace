using System.Collections.Generic;

namespace Ifood.Domain
{
    public class workingHours
    {
        /// <summary>
        /// ID do merchant (loja)
        /// </summary>
        public string storeId { get; set; }
        /// <summary>
        /// Lista de turnos de trabalho
        /// </summary>
        public List<workingHoursShift> shifts { get; set; }
    }
}
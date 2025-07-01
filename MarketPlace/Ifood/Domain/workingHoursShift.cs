namespace Ifood.Domain
{
    public class workingHoursShift
    {
        /// <summary>
        /// Identificador único do turno de horário de funcionamento
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Id do merchant (loja) ao qual o turno de horário de funcionamento pertence
        /// </summary>
        public string storeId { get; set; }
        /// <summary>
        /// Dia da semana (Valores aceitos: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY)
        /// </summary>
        public string dayOfWeek { get; set; }
        /// <summary>
        /// Hora de início do turno de horário de funcionamento (formato HH:mm:ss)
        /// </summary>
        public string start { get; set; }
        /// <summary>
        /// Duração do turno de horário de funcionamento em minutos
        /// </summary>
        public int duration { get; set; }
        /// <summary>
        /// Indica se o turno de horário de funcionamento está habilitado ou não
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// Data de criação do turno de horário de funcionamento
        /// </summary>
        public string createdAt { get; set; }
    }
}
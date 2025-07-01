namespace Ifood.Domain
{
    public class merchantReopenable
    {
        /// <summary>
        /// Identificador (id) para reabrir. Ex: "cca57aab-5ac0-4af4-a04d-48261350bebc"
        /// </summary>
        public string identifier { get; set; }
        /// <summary>
        /// Tipo ou motivo do fechamento Ex: "UNAVAILABILITY"
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Indica se o status pode ser reaberto
        /// </summary>
        public bool reopenable { get; set; }
    }
}
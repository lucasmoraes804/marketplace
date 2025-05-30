namespace Ifood.Domain
{
    public class merchantValidation
    {
        /// <summary>
        /// Código da validação. <br/><br/>
        /// <b>is-connected</b> - A loja está fazendo polling regularmente a cada 30 segundos. <br/>
        /// <b>opening-hours</b> - O horário atual está dentro de algum horário de funcionamento. <br/>
        /// <b>unavailabilities</b> - Há alguma interrupção no horário atual. <br/>
        /// <b>radius-restriction</b> - Há disponibilidade de entregadores na área. <br/>
        /// <b>payout-blocked</b> - Há pendências financeiras da loja. <br/>
        /// <b>logistics-blocked</b> - Há problemas logísticos na área da loja, vide festivais, trânsito intenso, etc. <br/>
        /// <b>terms-service-violation</b> - A loja violou os Termos de Serviço do iFood. <br/>
        /// <b>status-availability</b> - A loja está desativada, em fase de testes ou durante uma interrupção. <br/>
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Código completo da validação.
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// Estado atual da loja. <br/><br/>
        /// <b>OK</b> - Indica que a loja está online. <br/>
        /// <b>WARNING</b> - Indica que a loja está online, mas podem haver restrições como redução de área de entrega. <br/>
        /// <b>CLOSED</b> - Indica que a loja está fechada conforme esperado, como em casos de "fora do horário de funcionamento" ou "em pausa programada". Não requer nenhuma ação. <br/>
        /// <b>ERROR</b> - Indica que a loja está fechada por algum motivo não esperado. Requer uma ação da loja.
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// Mensagem de validação.
        /// </summary>
        public merchantMessage message { get; set; }
    }
}
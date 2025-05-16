using System.Collections.Generic;

namespace Ifood.Domain
{
    public class handshakeDisputeMetadata
    {
        /// <summary>
        /// Contém a lista de itens que podem ser cancelados no fluxo de Cancelamento Parcial. Em Disputes com a action PARTIAL_CANCELLATION.
        /// </summary>
        public List<handshakeItem> item { get; set; }
        /// <summary>
        /// Contém a lista de sub itens que podem ser cancelados no fluxo de Cancelamento Parcial. Em Disputes com a action PARTIAL_CANCELLATION.
        /// </summary>
        public List<handshakeGarnishItem> garnishItems { get; set; }
        /// <summary>
        /// Mídias enviadas pelo consumidor no momento da abertura do cancelamento. Actions CANCELLATION e PARTIAL_CANCELLATION.
        /// </summary>
        public List<handshakeMedia> evidences { get; set; }
        /// <summary>
        /// Lista de strings com possíveis motivos do porque a loja aceitou o cancelamento solicitado pelo cliente.
        /// </summary>
        public List<string> acceptCancellationReasons { get; set; }
    }
}
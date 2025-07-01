namespace Ifood.Domain
{
    public class handshakeMedia
    {
        /// <summary>
        /// url da mídia enviada enviada pelo consumidor
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// Tipo da mídia enviada
        /// </summary>
        public string contentType { get; set; }
    }
}
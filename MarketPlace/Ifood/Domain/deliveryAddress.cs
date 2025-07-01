using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class deliveryAddress
    {
        /// <summary>
        /// Nome da rua ou avenida
        /// </summary>
        public string streetName { get; set; }
        /// <summary>
        /// Número (Obs: pode conter letras)
        /// </summary>
        public string streetNumber { get; set; }
        /// <summary>
        /// Endereço formatado (Rua + Número)
        /// </summary>
        public string formattedAddress { get; set; }
        /// <summary>
        /// Bairro ou setor
        /// </summary>
        public string neighborhood { get; set; }
        /// <summary>
        /// Complemento (Ex: Apartamento, Quadra, Lote)
        /// </summary>
        public string complement { get; set; }        
        /// <summary>
        /// Ponto de referência
        /// </summary>
        public string reference { get; set; }
        /// <summary>
        /// Código postal (CEP). <br/> Campo opcional, eventualmente pode ser enviado zerado
        /// </summary>
        public string postalCode { get; set; }
        /// <summary>
        /// Cidade
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// Estado
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// País
        /// </summary>
        public string country { get; set; }
        public coordinates coordinates { get; set; }
    }

    public class coordinates
    {
        /// <summary>
        /// Latitude
        /// </summary>
        public string latitude { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public string longitude { get; set; }
    }
}

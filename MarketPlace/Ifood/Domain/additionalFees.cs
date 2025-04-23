using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood.Domain
{
    public class additionalFees
    {
        public additionalFees()
        {
            liabilities = new List<liabilities>();
        }
        
        /// <summary>
        /// Tipo de taxa (novas taxas podem ser adicionadas e devem ser tratadas como string)
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Descrição do tipo de taxa para ser exibida no aplicativo ou comanda impressa
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Descrição completa do tipo de taxa para ser exibida no aplicativo ou comanda impressa
        /// </summary>
        public string fullDescription { get; set; }
        /// <summary>
        /// Valor da taxa de serviço
        /// </summary>
        public decimal value { get; set; }
        /// <summary>
        /// Lista contendo informações dos responsáveis pela taxa e suas respectivas porcentagens
        /// </summary>
        public List<liabilities> liabilities { get; set; }
    }
}

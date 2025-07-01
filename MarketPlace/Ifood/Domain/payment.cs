using System.Collections.Generic;

namespace Ifood.Domain
{
    public class payment
    {
        public payment()
        {
            methods = new List<payment_methods>();
        }

        /// <summary>
        /// valor que já foi pago (ONLINE)
        /// </summary>
        public decimal prepaid { get; set; }
        /// <summary>
        /// valor pendente que deve ser cobrado no ato da entrega (OFFLINE)
        /// </summary>
        public decimal pending { get; set; }
        public List<payment_methods> methods { get; set; }       
    }

    public class payment_methods
    {
        /// <summary>
        /// valor do pagamento
        /// </summary>
        public decimal value { get; set; }
        /// <summary>
        /// moeda
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// tipo de pagamento: ONLINE (pagamento já foi feito online pelo aplicativo e não deve ser cobrado na entrega)
        /// ou OFFLINE (pagamento deve ser feito no ato da entrega do pedido)
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// método de pagamento (CASH / CREDIT / DEBIT / MEAL_VOUCHER / FOOD_VOUCHER / GIFT_CARD / DIGITAL_WALLET / PIX / OTHER)
        /// </summary>
        public string method { get; set; }
        public payment_methods_wallet wallet { get; set; }        
        public bool prepaid { get; set; }                
        public payment_methods_cash cash { get; set; }
        public payment_methods_card card { get; set; }
        public payment_methods_transaction transaction { get; set; }
    }

    public class payment_methods_wallet
    {
        /// <summary>
        /// nome da carteira (somente para pagamentos com carteira digital)
        /// </summary>
        public string name { get; set; }
    }

    public class payment_methods_cash
    {
        /// <summary>
        /// valor do troco
        /// </summary>
        public decimal changeFor { get; set; }
    }

    public class payment_methods_card
    {
        /// <summary>
        /// nome da bandeira do cartão
        /// </summary>
        public string brand { get; set; }
    }

    public class payment_methods_transaction
    {
        /// <summary>
        /// Número de autorização da operação cartão de crédito e/ou débito (Campo cAut da NFe).
        /// </summary>
        public string authorizationCode { get; set; }
        /// <summary>
        /// CNPJ do Intermediador da Transação (agenciado, plataforma de delivery, marketplace e similar) de serviços e negócios
        /// </summary>
        public string acquirerDocument { get; set; }
    }
}

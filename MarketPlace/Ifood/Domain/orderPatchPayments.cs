using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatchPayments
{
    public List<orderPatchPaymentMethod> methods { get; set; }
}
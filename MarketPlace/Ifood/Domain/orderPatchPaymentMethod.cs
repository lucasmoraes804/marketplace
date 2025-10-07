namespace Ifood.Domain;

public class orderPatchPaymentMethod
{
    public decimal value { get; set; }
    public string currency { get; set; }
    public string type { get; set; }
    public string method { get; set; }
    public orderPatchPaymentCard? card { get; set; }
}
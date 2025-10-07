namespace Ifood.Domain;

public class orderPatchOption
{
    public string id { get; set; }
    public string externalCode { get; set; }
    public object quantity { get; set; }
    public decimal? unitPrice { get; set; }
}
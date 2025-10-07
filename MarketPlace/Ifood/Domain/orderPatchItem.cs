namespace Ifood.Domain;

public class orderPatchItem
{
    public string id { get; set; }
    public string uniqueId { get; set; }
    public string externalCode { get; set; }
    public orderPatchChangeDetail changes { get; set; }
    public decimal unitPrice { get; set; }
    public fromTo<decimal> optionsPrice { get; set; }
    public fromTo<decimal> totalPrice { get; set; }
}
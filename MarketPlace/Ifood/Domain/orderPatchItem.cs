using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatchItem
{
    public string id { get; set; }
    public string uniqueId { get; set; }
    public string externalCode { get; set; }
    public orderPatchChangeDetail changes { get; set; }
    public List<orderPatchOption> options { get; set; }
    public decimal unitPrice { get; set; }
    public object optionsPrice { get; set; }
    public object totalPrice { get; set; }
}
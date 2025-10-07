using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatchChange
{
    public string changeType { get; set; }
    public List<orderPatchItem> items { get; set; }
}
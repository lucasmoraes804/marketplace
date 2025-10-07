using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatch
{
    public List<orderPatchChange> changes { get; set; }
    public orderPatchTotal total { get; set; }
    public orderPatchPayments payments { get; set; }
}
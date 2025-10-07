using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatchOptionChange
{
    public string changeType { get; set; }
    public List<orderPatchOption> options { get; set; }
}
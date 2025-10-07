using System.Collections.Generic;

namespace Ifood.Domain;

public class orderPatchChangeDetail
{
    public List<orderPatchOptionChange> optionsChanges { get; set; }
    public fromTo<string> quantity { get; set; }
    public fromTo<string> unit { get; set; }
}
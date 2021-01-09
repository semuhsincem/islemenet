
using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.Middle.RfqMiddle
{
    public interface IRfqTechnologyService
    {
        List<RfqTechnology> GetRfqTechnologiesByRfqId(int rfqId);
        List<RfqTechnology> RemoveOldListAndAddNewList(List<RfqTechnology> rfqTechnologies, int rfqId);
        RfqTechnology Add(RfqTechnology rfqTechnology);
    }
}

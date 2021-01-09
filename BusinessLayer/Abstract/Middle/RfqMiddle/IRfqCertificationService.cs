


using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.Middle.RfqMiddle
{
    public interface IRfqCertificationService
    {
        List<RfqCertification> GetRfqCertificationsByRfqId(int rfqId);
        List<RfqCertification> RemoveOldListAndAddNewList(List<RfqCertification> rfqCertifications, int rfqId);
        RfqCertification Add(RfqCertification rfqCertification);
    }
}

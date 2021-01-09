
using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.Middle.RfqMiddle
{
    public interface IRfqMaterialService
    {
        List<RfqMaterial> GetRfqMaterialsByRfqId(int rfqId);
        List<RfqMaterial> RemoveOldListAndAddNewList(List<RfqMaterial> rfqMaterials, int rfqId);
        RfqMaterial Add(RfqMaterial rfqMaterial);
    }
}

using BusinessLayer.Abstract.Middle.RfqMiddle;
using DataAccessLayer.Abstract.Middle.RfqMiddles;
using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Concrete.Middle.RfqMiddle
{
    public class RfqMaterialManager : IRfqMaterialService
    {
        private IRfqMaterialDal _rfqMaterialDal { get; set; }
        public RfqMaterialManager(IRfqMaterialDal rfqMaterialDal)
        {
            _rfqMaterialDal = rfqMaterialDal;
        }
        public RfqMaterial Add(RfqMaterial rfqMaterial)
        {
            return _rfqMaterialDal.Add(rfqMaterial);
        }

        public List<RfqMaterial> GetRfqMaterialsByRfqId(int rfqId)
        {
            return _rfqMaterialDal.GetList(x=>x.Id == rfqId);
        }

        public List<RfqMaterial> RemoveOldListAndAddNewList(List<RfqMaterial> rfqMaterials, int rfqId)
        {
            _rfqMaterialDal.GetList(x => x.RFQId == rfqId).ForEach(x => {
                _rfqMaterialDal.Delete(x.Id);
            });
            foreach (var item in rfqMaterials)
            {
                _rfqMaterialDal.Add(new RfqMaterial() { RFQId = rfqId, MaterialId = item.MaterialId });
            }
            return rfqMaterials;
        }
    }
}

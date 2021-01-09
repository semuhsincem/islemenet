
using BusinessLayer.Abstract.Middle.RfqMiddle;
using DataAccessLayer.Abstract.Middle.RfqMiddles;
using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Concrete.Middle.RfqMiddle
{
    public class RfqCertificationManager : IRfqCertificationService
    {
        private IRfqCertificationDal _rfqCertificationDal { get; set; }
        public RfqCertificationManager(IRfqCertificationDal rfqCertificationDal)
        {
            _rfqCertificationDal = rfqCertificationDal;
        }
        public RfqCertification Add(RfqCertification rfqCertification)
        {
            return _rfqCertificationDal.Add(rfqCertification);
        }

        public List<RfqCertification> GetRfqCertificationsByRfqId(int rfqId)
        {
            return _rfqCertificationDal.GetList(x => x.Id == rfqId);
        }

        public List<RfqCertification> RemoveOldListAndAddNewList(List<RfqCertification> rfqCertifications, int rfqId)
        {
            _rfqCertificationDal.GetList(x => x.RFQId == rfqId).ForEach(x => {
                _rfqCertificationDal.Delete(x.Id);
            });
            foreach (var item in rfqCertifications)
            {
                _rfqCertificationDal.Add(new RfqCertification() { RFQId = rfqId, CertificationId = item.CertificationId });
            }
            return rfqCertifications;
        }
    }
}

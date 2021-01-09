using BusinessLayer.Abstract.Middle.RfqMiddle;
using DataAccessLayer.Abstract.Middle.RfqMiddles;
using Entities.Abstract.MiddleTables.RFQMiddles;
using System.Collections.Generic;

namespace BusinessLayer.Concrete.Middle.RfqMiddle
{
    public class RfqTechnologyManager : IRfqTechnologyService
    {
        private IRfqTechnologyDal _rfqTechnologyDal { get; set; }
        public RfqTechnologyManager(IRfqTechnologyDal rfqTechnologyDal)
        {
            _rfqTechnologyDal = rfqTechnologyDal;
        }
        public RfqTechnology Add(RfqTechnology rfqTechnology)
        {
            return _rfqTechnologyDal.Add(rfqTechnology);
        }

        public List<RfqTechnology> GetRfqTechnologiesByRfqId(int rfqId)
        {
            return _rfqTechnologyDal.GetList(x => x.RFQId == rfqId);
        }

        public List<RfqTechnology> RemoveOldListAndAddNewList(List<RfqTechnology> rfqTechnologies, int rfqId)
        {
            _rfqTechnologyDal.GetList(x => x.RFQId == rfqId).ForEach(x => {
                _rfqTechnologyDal.Delete(x.Id);
            });
            foreach (var item in rfqTechnologies)
            {
                _rfqTechnologyDal.Add(new RfqTechnology() { RFQId = rfqId,  TechnologyId = item.TechnologyId });
            }
            return rfqTechnologies;
        }
    }
}

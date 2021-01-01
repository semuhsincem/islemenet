using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class RFQCountryManager : IRFQCountryService
    {
        private IRFQCountryDal _rfqService { get; set; }
        public RFQCountryManager(IRFQCountryDal rfqService)
        {
            _rfqService = rfqService;
        }
        public void AddCountriesToRFQ(List<int> countryIdList, int rfqId)
        {
            foreach (var item in countryIdList)
            {
                _rfqService.Add(new RFQCountry() { RFQId = rfqId, CountryCode = item });
            }
        }

        public List<RFQCountry> GetCountryListByRFQId(int rfqId)
        {
            return _rfqService.GetList(x => x.RFQId == rfqId);
        }

        public void UpdateCountriesToRFQ(List<int> countryIdList, int rfqId)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

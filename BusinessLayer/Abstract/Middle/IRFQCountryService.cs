using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.Middle
{
    public interface IRFQCountryService
    {
        List<RfqCountry> GetCountryListByRFQId(int rfqId);

        void AddCountriesToRFQ(List<int> countryIdList, int rfqId);

        void UpdateCountriesToRFQ(List<int> countryIdList, int rfqId);

    }
}

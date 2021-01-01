using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface IRFQCountryService
    {
        List<RFQCountry> GetCountryListByRFQId(int rfqId);

        void AddCountriesToRFQ(List<int> countryIdList, int rfqId);

        void UpdateCountriesToRFQ(List<int> countryIdList, int rfqId);

    }
}

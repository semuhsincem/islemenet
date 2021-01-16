using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ViewModels.RFQ;

namespace BusinessLayer.Abstract
{
    public interface IRFQService
    {
        RFQ AddAdvertisment(RFQ advertisement);

        RFQ DeleteAdvertisement(RFQ advertisement);

        List<RFQ> GetAdvertisements(Expression<Func<RFQ, bool>> expression = null);
        List<RFQ> GetRfqWithIncludes(SearchRfqViewModel model = null, int skip=0, int take = 10);
    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IRFQService
    {
        RFQ AddAdvertisment(RFQ advertisement);

        RFQ DeleteAdvertisement(RFQ advertisement);

        List<RFQ> GetAdvertisements(Expression<Func<RFQ, bool>> expression = null);
    }
}

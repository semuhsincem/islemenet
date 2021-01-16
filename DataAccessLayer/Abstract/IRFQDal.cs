using Core;
using Entities.Concrete;
using System.Collections.Generic;
using ViewModels.RFQ;

namespace DataAccessLayer.Abstract
{
    public interface IRFQDal : IRepository<RFQ>
    {
        List<RFQ> GetListAllInclude(SearchRfqViewModel model = null, int skip = 0, int take = 10);
    }
}

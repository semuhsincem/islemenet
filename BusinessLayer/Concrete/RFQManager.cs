using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ViewModels.RFQ;

namespace BusinessLayer.Concrete
{
    public class RFQManager : IRFQService
    {
        private readonly IRFQDal _advService;

        public RFQManager(IRFQDal advService)
        {
            _advService = advService;
        }
        public RFQ AddAdvertisment(RFQ advertisement)
        {
            return _advService.Add(advertisement);
        }

        public RFQ DeleteAdvertisement(RFQ advertisement)
        {
            return _advService.Delete(advertisement.Id);
        }

        public List<RFQ> GetAdvertisements(Expression<Func<RFQ, bool>> expression = null)
        {
            return _advService.GetList(expression);
        }

        public List<RFQ> GetRfqWithIncludes(SearchRfqViewModel model = null, int skip = 0, int take = 10)
        {
            return _advService.GetListAllInclude(model, skip,take).ToList();
        }
    }
}

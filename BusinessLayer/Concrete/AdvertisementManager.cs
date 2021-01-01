using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AdvertisementManager : IAdvertisementService
    {
        private readonly IAdvertisementDal _advService;

        public AdvertisementManager(IAdvertisementDal advService)
        {
            _advService = advService;
        }
        public Advertisement AddAdvertisment(Advertisement advertisement)
        {
            return _advService.Add(advertisement);
        }

        public Advertisement DeleteAdvertisement(Advertisement advertisement)
        {
            return _advService.Delete(advertisement.Id);
        }

        public List<Advertisement> GetAdvertisements(Expression<Func<Advertisement, bool>> expression = null)
        {
            return _advService.GetList(expression);
        }
    }
}

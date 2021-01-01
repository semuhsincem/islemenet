using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAdvertisementService
    {
        Advertisement AddAdvertisment(Advertisement advertisement);

        Advertisement DeleteAdvertisement(Advertisement advertisement);

        List<Advertisement> GetAdvertisements(Expression<Func<Advertisement,bool>> expression = null);
    }
}

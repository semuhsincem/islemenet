using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRFQDal : EfRepositoryBase<CNCContext, RFQ>, IRFQDal
    {
        public List<RFQ> GetListAllInclude(Expression<Func<RFQ, bool>> exp = null)
        {
            using (var context = new CNCContext())
            {
                if (exp == null)
                {

                    var res = context.Set<RFQ>()
                        .Include(x => x.RfqTechnologies)
                        .Include(x => x.RfqMaterials)
                        .Include(x => x.RfqCertifications)
                        .Include(x => x.RfqFiles).ToList();
                    return res;
                }
                else
                {
                    var res = context.Set<RFQ>()
                        .Where(exp)
                     .Include(x => x.RfqTechnologies)
                     .Include(x => x.RfqMaterials)
                     .Include(x => x.RfqCertifications)
                     .Include(x => x.RfqFiles).ToList();
                    return res;
                }
            }
        }
    }
}

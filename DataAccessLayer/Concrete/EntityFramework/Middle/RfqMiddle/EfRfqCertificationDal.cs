using Core.EntityFramework;
using DataAccessLayer.Abstract.Middle.RfqMiddles;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Abstract.MiddleTables.RFQMiddles;

namespace DataAccessLayer.Concrete.EntityFramework.Middle.RfqMiddle
{
    public class EfRfqCertificationDal : EfRepositoryBase<CNCContext, RfqCertification>, IRfqCertificationDal
    {
    }
}

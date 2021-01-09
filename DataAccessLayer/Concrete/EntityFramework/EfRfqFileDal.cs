using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRfqFileDal : EfRepositoryBase<CNCContext, RfqFile>, IRfqFileDal
    {
    }
}

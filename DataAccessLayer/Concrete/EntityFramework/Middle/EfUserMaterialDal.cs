using Core.EntityFramework;
using DataAccessLayer.Abstract.Middle;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework.Middle
{
    public class EfUserMaterialDal : EfRepositoryBase<CNCContext, UserMaterial>, IUserMaterialDal
    {
    }
}

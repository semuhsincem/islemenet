using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface IUserTechnologyService
    {
        List<UserTechnology> GetUserTechnologiesByUserId(int userId);
        List<UserTechnology> RemoveOldListAndAddNewList(List<UserTechnology> userTechnologies, int UserId);
        UserTechnology Add(UserTechnology userTechnology);
    }
}

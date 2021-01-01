using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface IUserIndustryService
    {
        List<UserIndustry> GetUserIndustriesByUserId(int userId);
        List<UserIndustry> RemoveOldListAndAddNewList(List<UserIndustry> userIndustries, int UserId);
        UserIndustry Add(UserIndustry userIndustry);
    }
}

using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class UserIndustryManager : IUserIndustryService
    {
        public readonly IUserIndustryDal _userIndustryService;
        public UserIndustryManager(IUserIndustryDal userIndustryService)
        {
            _userIndustryService = userIndustryService;
        }

        public UserIndustry Add(UserIndustry userIndustry)
        {
            return _userIndustryService.Add(userIndustry);
        }

        public List<UserIndustry> GetUserIndustriesByUserId(int userId)
        {
            return _userIndustryService.GetList(x => x.UserId == userId);
        }

        public List<UserIndustry> RemoveOldListAndAddNewList(List<UserIndustry> userIndustries, int UserId)
        {
            var res = GetUserIndustriesByUserId(UserId);

            res.ForEach(x => {
                _userIndustryService.Delete(x.Id);
            });

            userIndustries.ForEach(x =>
            {
                _userIndustryService.Add(x);
            });

            return userIndustries;
        }
    }
}

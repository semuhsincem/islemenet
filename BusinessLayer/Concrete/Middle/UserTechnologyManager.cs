using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class UserTechnologyManager : IUserTechnologyService
    {
        public readonly IUserTechnologyDal _userTechnologyService;
        public UserTechnologyManager(IUserTechnologyDal userTechnologyService)
        {
            _userTechnologyService = userTechnologyService;
        }

        public UserTechnology Add(UserTechnology userTechnology)
        {
            return _userTechnologyService.Add(userTechnology);
        }

        public List<UserTechnology> GetUserTechnologiesByUserId(int userId)
        {
            return _userTechnologyService.GetList(x => x.UserId == userId);
        }

        public List<UserTechnology> RemoveOldListAndAddNewList(List<UserTechnology> userTechnologies, int UserId)
        {
            var res = GetUserTechnologiesByUserId(UserId);
            
            res.ForEach(x=> {
                _userTechnologyService.Delete(x.Id);
            });

            userTechnologies.ForEach(x =>
            {
                _userTechnologyService.Add(x);
            });

            return userTechnologies;
        }
    }
}

using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class UserMaterialManager : IUserMaterialService
    {
        public readonly IUserMaterialDal _userMaterialService;
        public UserMaterialManager(IUserMaterialDal userMaterialService)
        {
            _userMaterialService = userMaterialService;
        }

        public UserMaterial Add(UserMaterial userMaterial)
        {
            return _userMaterialService.Add(userMaterial);
        }

        public List<UserMaterial> GetUserMaterialsByUserId(int userId)
        {
            return _userMaterialService.GetList(x => x.UserId == userId);
        } 
        public List<UserMaterial> RemoveOldListAndAddNewList(List<UserMaterial> userMaterials, int UserId)
        {
            var res = GetUserMaterialsByUserId(UserId);

            res.ForEach(x => {
                _userMaterialService.Delete(x.Id);
            });

            userMaterials.ForEach(x =>
            {
                _userMaterialService.Add(x);
            });

            return userMaterials;
        }

    }
}

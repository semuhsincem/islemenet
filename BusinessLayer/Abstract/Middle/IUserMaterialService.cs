using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface IUserMaterialService
    {
        List<UserMaterial> GetUserMaterialsByUserId(int userId);
        List<UserMaterial> RemoveOldListAndAddNewList(List<UserMaterial> userMaterials, int UserId);
        UserMaterial Add(UserMaterial userMaterial);
    }
}

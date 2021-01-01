using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface IUserCertificateService
    {
        List<UserCertification> GetCertificatesByUserId(int userId);
        List<UserCertification> RemoveOldListAndAddNewList(List<UserCertification> certifications, int UserId);
        UserCertification Add(UserCertification certifications);

    }
}

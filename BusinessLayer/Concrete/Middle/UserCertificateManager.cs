using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class UserCertificateManager : IUserCertificateService
    {
        public readonly IUserCertificationDal _userCertificationService;
        public UserCertificateManager(IUserCertificationDal userCertificationService)
        {
            _userCertificationService = userCertificationService;
        }

        public UserCertification Add(UserCertification certifications)
        {
            return _userCertificationService.Add(certifications);
        }

        public List<UserCertification> GetCertificatesByUserId(int userId)
        {
            return _userCertificationService.GetList(x => x.UserId == userId);
        }

        public List<UserCertification> RemoveOldListAndAddNewList(List<UserCertification> certifications, int UserId)
        {
            var res = GetCertificatesByUserId(UserId);

            res.ForEach(x => {
                _userCertificationService.Delete(x.Id);
            });

            certifications.ForEach(x =>
            {
                _userCertificationService.Add(x);
            });

            return certifications;
        }

       
        
    }
}

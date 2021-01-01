using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract.MiddleTables
{
    public class UserCertification:BaseEntity,IEntity
    {
        public int UserId { get; set; }
        public int CertificaId { get; set; }
    }
}

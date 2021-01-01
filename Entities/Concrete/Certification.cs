using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Certification :BaseEntity ,IEntity
    {
        public string CertificateName { get; set; }

    }
}

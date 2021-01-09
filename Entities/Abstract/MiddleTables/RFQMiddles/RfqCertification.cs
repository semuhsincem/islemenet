using Core;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract.MiddleTables.RFQMiddles
{
    public class RfqCertification : BaseEntity, IEntity
    {
        public int RFQId { get; set; }
        public int CertificationId { get; set; }

        [ForeignKey(nameof(RFQId))]
        public virtual RFQ RFQ { get; set; }
    }
}

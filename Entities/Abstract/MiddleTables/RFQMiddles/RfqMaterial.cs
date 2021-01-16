using Core;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract.MiddleTables.RFQMiddles
{
    public class RfqMaterial : BaseEntity, IEntity
    {
        public int RFQId { get; set; }
        public int MaterialId { get; set; }

        [ForeignKey(nameof(RFQId))]
        public virtual RFQ RFQ { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public virtual Material Material { get; set; }
    }
}

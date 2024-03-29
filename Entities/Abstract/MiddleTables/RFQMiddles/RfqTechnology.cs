﻿using Core;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract.MiddleTables.RFQMiddles
{
    public class RfqTechnology : BaseEntity, IEntity
    {

        public int RFQId { get; set; }
        [ForeignKey(nameof(RFQId))]
        public virtual RFQ RFQ { get; set; }
        public int TechnologyId { get; set; }

        [ForeignKey(nameof(TechnologyId))]
        public virtual Technology Technology { get; set; }
    }
}

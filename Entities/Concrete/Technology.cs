using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Technology : BaseEntity ,IEntity
    {
        public string TechnologyName { get; set; }

    }
}

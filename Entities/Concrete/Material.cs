using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Material :BaseEntity , IEntity
    {
        public string MaterialName { get; set; }

    }
}

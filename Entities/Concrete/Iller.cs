using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Iller : BaseEntity, IEntity
    {
        public string Ad { get; set; }
        public int Plaka { get; set; }
    }
}

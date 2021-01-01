using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract.MiddleTables
{
    public class Language : BaseEntity, IEntity
    {
        public string Lang { get; set; }
        public string Alias { get; set; }
    }
}

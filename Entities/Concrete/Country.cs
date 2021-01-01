using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Country : BaseEntity , IEntity
    {
        public string CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public string ISO3 { get; set; }
        public int COUNTRY_NUMBER { get; set; }
        public string CONTINENT_CODE { get; set; }
    }
}

﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract.MiddleTables
{
    public class RFQCountry : BaseEntity, IEntity
    {
        public int CountryCode { get; set; }
        public int RFQId { get; set; }

    }
}

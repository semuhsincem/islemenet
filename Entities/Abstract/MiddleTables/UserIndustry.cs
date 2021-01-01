using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract.MiddleTables
{
    public class UserIndustry : BaseEntity , IEntity
    {
        public int UserId { get; set; }
        public int IndustryId { get; set; }
    }
}

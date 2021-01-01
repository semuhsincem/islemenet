using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core
{
    public class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? AtCreated { get; set; }
        public DateTime? AtModified { get; set; }
        public DateTime? AtDeleted { get; set; }
        public bool IsActive { get; set; }
        public BaseEntity()
        {
            IsActive = true;
            IsDeleted = false;
        }

    }
}

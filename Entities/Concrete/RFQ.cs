using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("RFQ")]
    public class RFQ :BaseEntity , IEntity
    {
        public string Title { get; set; }

        public int Quantity { get; set; }
        public int Need { get; set; }
        public DateTime RFQDeadline { get; set; }
        public DateTime DelivaryDate { get; set; }
        public string CustomRFQId { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Diameter { get; set; }
        public int MinTol { get; set; }
        public string BasicInformation { get; set; }
        public string OfferCurrency { get; set; }
        public int CorrespondenceLanguage { get; set; }
        public int PublicationSettingsType { get; set; }

        public int RfqFilesId { get; set; }
        public virtual List<RfqFile> RfqFiles { get; set; }

    }
}

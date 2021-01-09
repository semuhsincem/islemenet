using Core;
using Enums.RFQHelpers;

namespace Entities.Concrete
{
    public class RfqFile : BaseEntity, IEntity
    {
        public int RFQId { get; set; }
        public string FilePath { get; set; }
        public ECreateRfqFileType FileType { get; set; }
    }
}

using Entities.Concrete;
using Enums.RFQHelpers;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.Middle
{
    public interface IRfqFileService
    {
        List<RfqFile> GetRfqFileByRFQId(int rfqId,ECreateRfqFileType fileType);
        void AddFileToRFQ(List<string> filePaths, int rfqId, ECreateRfqFileType fileType);
        void UpdateFilesToRFQ(List<string> filePath, int rfqId, ECreateRfqFileType fileType);
    }
}

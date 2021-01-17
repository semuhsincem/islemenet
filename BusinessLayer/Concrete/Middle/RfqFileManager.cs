using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Enums.RFQHelpers;
using System.Collections.Generic;

namespace BusinessLayer.Concrete.Middle
{
    public class RfqFileManager : IRfqFileService
    {
        private IRfqFileDal _rfqFileDal { get; set; }
        public RfqFileManager(IRfqFileDal rfqFileDal)
        {
            _rfqFileDal = rfqFileDal;
        }
        public void AddFileToRFQ(List<string> filePaths, int rfqId, ECreateRfqFileType fileType)
        {
            foreach (var item in filePaths)
            {
                _rfqFileDal.Add(new RfqFile() { RFQId = rfqId, FileType = fileType, FilePath = item});
            }
        }
        public List<RfqFile> GetRfqFileByRFQId(int rfqId, ECreateRfqFileType fileType)
        {
            return _rfqFileDal.GetList(x => x.RFQId == rfqId && x.FileType == fileType);
        }
        public void UpdateFilesToRFQ(List<string> filePath, int rfqId, ECreateRfqFileType fileType)
        {
            _rfqFileDal.GetList(x => x.RFQId == rfqId).ForEach(x => {
                _rfqFileDal.Delete(x.Id);
            });
            foreach (var item in filePath)
            {
                _rfqFileDal.Add(new RfqFile() { RFQId = rfqId, FileType = fileType, FilePath = item });
            }
        }

        public RfqFile GetRfqFile(int id)
        {
            var res = _rfqFileDal.Get(id);
            return res;
        }
    }
}

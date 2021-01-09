using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ConstantManager : IConstantService
    {
        private readonly ICertificationDal _certificationService;
        private readonly ICompanySizeDal _companySizeService;
        private readonly ICountryDal _countryService;
        private readonly IIndustryDal _industryService;
        private readonly IMaterialDal _materialService;
        private readonly ITechnologyDal _technologyService;
        private readonly IIllerDal _illerService;
        private readonly IRfqFileDal _rfqFileDal;
        public ConstantManager(
        ICertificationDal certificationService,
        ICompanySizeDal companySizeService,
        ICountryDal countryService,
        IIndustryDal industryService,
        IMaterialDal materialService,
        ITechnologyDal technologyService,
        IIllerDal illerService,
        IRfqFileDal rfqFileDal)
        {
            _certificationService = certificationService;
            _companySizeService = companySizeService;
            _countryService = countryService;
            _materialService = materialService;
            _industryService = industryService;
            _technologyService = technologyService;
            _illerService = illerService;
            _rfqFileDal = rfqFileDal;
        }
        public List<Certification> GetCertifications(Expression<Func<Certification, bool>> expression = null)
        {
            return _certificationService.GetList(expression);
        }

        public List<CompanySize> GetCompanySizes(Expression<Func<CompanySize, bool>> expression = null)
        {
            return _companySizeService.GetList(expression);
        }

        public List<Country> GetCountries(Expression<Func<Country, bool>> expression = null)
        {
            return _countryService.GetList(expression);
        }

        public List<Iller> GetIller(Expression<Func<Iller, bool>> expression = null)
        {
            return _illerService.GetList(expression);
        }

        public List<Industry> GetIndustries(Expression<Func<Industry, bool>> expression = null)
        {
            return _industryService.GetList(expression);
        }

        public List<Material> GetMaterials(Expression<Func<Material, bool>> expression = null)
        {
            return _materialService.GetList(expression);
        }

        public List<Technology> GetTechnologies(Expression<Func<Technology, bool>> expression = null)
        {
            return _technologyService.GetList(expression);
        }
        public List<RfqFile> GetRfqFiles(Expression<Func<RfqFile, bool>> expression = null)
        {
            return _rfqFileDal.GetList(expression);
        }
    }
}

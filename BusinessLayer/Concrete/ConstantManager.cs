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
        private ICertificationDal _certificationService;
        private ICompanySizeDal _companySizeService;
        private ICountryDal _countryService;
        private IIndustryDal _industryService;
        private IMaterialDal _materialService;
        private ITechnologyDal _technologyService;
        private IIllerDal _illerService;
        public ConstantManager(
        ICertificationDal certificationService,
        ICompanySizeDal companySizeService,
        ICountryDal countryService,
        IIndustryDal industryService,
        IMaterialDal materialService,
        ITechnologyDal technologyService,
        IIllerDal illerService)
        {
            _certificationService = certificationService;
            _companySizeService = companySizeService;
            _countryService = countryService;
            _materialService = materialService;
            _industryService = industryService;
            _technologyService = technologyService;
            _illerService = illerService;

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
    }
}

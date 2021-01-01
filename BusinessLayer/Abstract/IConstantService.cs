using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IConstantService
    {
        List<Certification> GetCertifications(Expression<Func<Certification,bool>> expression = null);
        List<CompanySize> GetCompanySizes(Expression<Func<CompanySize, bool>> expression = null);
        List<Country> GetCountries(Expression<Func<Country, bool>> expression = null);
        List<Material> GetMaterials(Expression<Func<Material, bool>> expression = null);
        List<Technology> GetTechnologies(Expression<Func<Technology, bool>> expression = null);
        List<Industry> GetIndustries(Expression<Func<Industry, bool>> expression = null);
        List<Iller> GetIller(Expression<Func<Iller, bool>> expression = null);
    }
}

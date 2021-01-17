using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ViewModels.RFQ;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRFQDal : EfRepositoryBase<CNCContext, RFQ>, IRFQDal
    {
        public List<RFQ> GetListAllInclude(SearchRfqViewModel model = null, int skip = 0, int take = 10)
        {
            using (var context = new CNCContext())
            {
                if (model == null)
                {

                    var res = context.Set<RFQ>()
                        .Include(x => x.RfqTechnologies).ThenInclude(x => x.Technology)
                        .Include(x => x.RfqMaterials).ThenInclude(x => x.Material)
                        .Include(x => x.RfqCertifications).ThenInclude(x => x.Certification)
                        .Include(x => x.RfqFiles)
                        .Skip(skip).Take(take).ToList();
                    return res;
                }
                else
                {
                    var res = context.Set<RFQ>()
                     .Include(x => x.RfqTechnologies).ThenInclude(x => x.Technology)
                     .Include(x => x.RfqMaterials).ThenInclude(x => x.Material)
                     .Include(x => x.RfqCertifications).ThenInclude(x => x.Certification)
                     .Include(x => x.RfqFiles).AsQueryable();

                    if (!string.IsNullOrEmpty(model.Searchkey))
                    {
                        res = res.Where(x=>x.Title.Contains(model.Searchkey) || x.BasicInformation.Contains(model.Searchkey));
                    }

                    if (model.SelectedMaterials?.Length > 0)
                        res = res.Where(x => x.RfqMaterials.Select(v => v.MaterialId).Any(y => model.SelectedMaterials.Any(z => z == y.ToString())));
                    if (model.SelectedTechnologies?.Length > 0)
                        res = res.Where(x => x.RfqTechnologies.Select(v => v.TechnologyId).Any(y => model.SelectedTechnologies.Any(z => z == y.ToString())));
                    if (model.SelectedCertifications?.Length > 0)
                        res = res.Where(x => x.RfqCertifications.Select(v => v.CertificationId).Any(y => model.SelectedCertifications.Any(z => z == y.ToString())));

                    if (model.MinDiameter > 0)
                        res = res.Where(x => x.Diameter >= model.MaxDiameter);
                    if (model.MaxDiameter > 0)
                        res = res.Where(x => x.Diameter <= model.MaxDiameter);

                    if (model.MinHeight > 0)
                        res = res.Where(x => x.Height >= model.MinHeight);
                    if (model.MaxHeight > 0)
                        res = res.Where(x => x.Height <= model.MaxHeight);

                    if (model.MinLength > 0)
                        res = res.Where(x => x.Length >= model.MinLength);
                    if (model.MaxLength > 0)
                        res = res.Where(x => x.Length <= model.MaxLength);

                    if (model.MinWidth > 0)
                        res = res.Where(x => x.Width >= model.MinWidth);
                    if (model.MaxWidth > 0)
                        res = res.Where(x => x.Width <= model.MaxWidth);

                    if (model.MinQuantity > 0)
                        res = res.Where(x => x.Quantity >= model.MinQuantity);
                    if (model.MaxQuantity > 0)
                        res = res.Where(x => x.Quantity <= model.MaxQuantity);
                    return res.Skip(skip).Take(take).ToList();
                }
            }
        }

        public RFQ GetRFQAllIncludeById(int id)
        {
            using (var context = new CNCContext())
            {

                var res = context.Set<RFQ>()
                    .Where(x => x.Id == id)
                    .Include(x => x.RfqTechnologies).ThenInclude(x => x.Technology)
                    .Include(x => x.RfqMaterials).ThenInclude(x => x.Material)
                    .Include(x => x.RfqCertifications).ThenInclude(x => x.Certification)
                    .Include(x => x.RfqFiles)
                    .FirstOrDefault();
                return res;

            }
        }
    }
}

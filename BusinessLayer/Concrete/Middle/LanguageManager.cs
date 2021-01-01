using BusinessLayer.Abstract.Middle;
using DataAccessLayer.Abstract.Middle;
using DataAccessLayer.Concrete.EntityFramework.Middle;
using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete.Middle
{
    public class LanguageManager : ILanguageService
    {
        private ILanguageDal _languageService;
        public LanguageManager(ILanguageDal languageService)
        {
            _languageService = languageService;
        }
        public List<Language> GetLanguages()
        {
            return _languageService.GetList();
        }
    }
}

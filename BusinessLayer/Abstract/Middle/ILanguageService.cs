using Entities.Abstract.MiddleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract.Middle
{
    public interface ILanguageService
    {
        public List<Language> GetLanguages();
    }
}

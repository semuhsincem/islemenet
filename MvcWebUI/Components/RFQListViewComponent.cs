using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MvcWebUI.Components
{
    public class RFQListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

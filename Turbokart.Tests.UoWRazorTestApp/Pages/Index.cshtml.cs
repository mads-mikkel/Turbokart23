using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Turbokart.Infrastructure.Persistence.Interfaces;

namespace Turbokart.Tests.UoWRazorTestApp.Pages
{
    public class IndexModel: PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUnitOfWork unitOfWork;

        public IndexModel(ILogger<IndexModel> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork => unitOfWork;

        public void OnGet()
        {

        }
    }
}
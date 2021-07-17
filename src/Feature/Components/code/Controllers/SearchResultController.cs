using Final.Feature.Components.Repositories;
using System.Web.Mvc;

namespace Final.Feature.Components.Controllers
{
    public class SearchResultController : Controller
    {
        private readonly ISearchResultRepository _modelRepository;

        public SearchResultController(ISearchResultRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public ActionResult Index()
        {
            var searchQuery = Request.Form["searchQuery"];

            return View(_modelRepository.GetModel(searchQuery));
        }
    }
}
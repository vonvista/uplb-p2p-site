using Microsoft.AspNetCore.Mvc;
using UPLB_P2P.Website.Models.ViewModels;

namespace UPLB_P2P.Website.Controllers
{
    public class ReviewsController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Add(AddReviewRequest addReviewRequest)
        {
            var rating = addReviewRequest.Rating;
            var title = addReviewRequest.Title;
            var content = addReviewRequest.Content;
            return View("Add");
        }

    }
}

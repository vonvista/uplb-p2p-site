using Microsoft.AspNetCore.Mvc;
using UPLB_P2P.Website.Data;
using UPLB_P2P.Website.Models.Domain;
using UPLB_P2P.Website.Models.ViewModels;

namespace UPLB_P2P.Website.Controllers
{
    public class AdminUsersController : Controller
    {
        private P2PDbContext _p2pDbContext;
        public AdminUsersController(P2PDbContext p2pDbContext)
        {
            _p2pDbContext = p2pDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        //[ActionName("Add")]
        public IActionResult Add(AddUserRequest addUserRequest)
        {
            //var username = Request.Form["username"];
            //var email = Request.Form["email"];
            //var password = Request.Form["password"];

            //var username = addUserRequest.Username;
            //var email = addUserRequest.Email;
            //var password = addUserRequest.Password;
            //DateTime createDate = DateTime.Now;

            //mapping the AddUserRequest request to the User domain model
            var newUser = new User
            {
                Username = addUserRequest.Username,
                Email = addUserRequest.Email,   
                Password = addUserRequest.Password,
                CreatedAt = DateTime.Now
            };

            _p2pDbContext.Users.Add(newUser);
            _p2pDbContext.SaveChanges();

            return View("Add");
        }
    }
}

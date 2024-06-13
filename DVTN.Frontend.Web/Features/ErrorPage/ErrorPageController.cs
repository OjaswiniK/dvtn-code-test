using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Features.ErrorPage
{
    [Route("ErrorPage/{statuscode}")]
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int statuscode)
        {
            switch (statuscode)
            {
                case 404:
                    return View("Error404");
                case 500:
                    return View("Error500");
                default:
                    return View("Error");
            }
           // return View("ErrorPage");
        }


        [Route("/Error404")]
        public IActionResult Error404()
        {
            return View();
        }

        [Route("/Error500")]
        public IActionResult Error500()
        {
            return View();
        }

        [Route("/Error{0}")]
        public IActionResult Error(int statusCode)
        {           
           return View();
          
        }
    }
}

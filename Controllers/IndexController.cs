using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers 
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my index page!";
        }
                [HttpGet("projects")]
        public string Projects()
        {
            return "This is my project page!";
        }
                [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact page!";
        }
    }
}
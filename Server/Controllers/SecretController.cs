using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class SecretController : Controller
    {
        // Secret message to be authorize 

        [Authorize]
        public string Index()
        {
            return "This is the secret message";
        }
    }
}

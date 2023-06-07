using BancoKognit.Application.Services;
using BancoKognit.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BancoKognit.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Create User")]
        public HttpResponseMessage CreateUser([FromBody]UserViewModel userViewModel)
        {
            HttpResponseMessage responseMessage;
            UserAppService userAppService = new UserAppService(); 

            if (ModelState.IsValid)
            {
                return responseMessage = userAppService.Register(userViewModel);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    };
}

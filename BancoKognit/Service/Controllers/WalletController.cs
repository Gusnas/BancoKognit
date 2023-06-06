using BancoKognit.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoKognit.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ILogger<WalletController> _logger;

        public WalletController(ILogger<WalletController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "CreateWallet")]
        public void CreateWallet()
        {
        }

        [HttpGet(Name = "GetAllWallets")]
        public void GetAllWallets()
        {
        }
    };
}

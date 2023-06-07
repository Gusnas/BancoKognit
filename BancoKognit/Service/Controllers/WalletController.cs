using BancoKognit.Application.Services;
using BancoKognit.Application.ViewModels;
using BancoKognit.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public ActionResult CreateWallet([FromBody] WalletViewModel walletViewModel)
        {
            try
            {
                HttpResponseMessage _responseMessage;
                WalletAppService walletAppService = new WalletAppService();

                _responseMessage = walletAppService.Register(walletViewModel);

                if (_responseMessage.IsSuccessStatusCode)
                    return Ok(_responseMessage);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest();
        }

        [HttpGet(Name = "GetWalletsByUserId")]
        public ActionResult GetWalletsByUserId(Guid userId)
        {
            try
            {
                WalletAppService walletAppService = new WalletAppService();

                if (ModelState.IsValid)
                {
                    List<Wallet> wallets = walletAppService.GetWalletsByUserId(userId);
                    return Ok(wallets);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest();
        }
    };
}

using BancoKognit.Application.ViewModels;
using BancoKognit.Domain.Models;
using BancoKognit.Infra.Context;
using System.Net;

namespace BancoKognit.Application.Services
{
    public class WalletAppService
    {
        private readonly BankContext _bankContext;

        public WalletAppService()
        {
            _bankContext = new BankContext();
        }

        public HttpResponseMessage Register(WalletViewModel walletViewModel)
        {
            if (walletViewModel == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            var wallet = new Wallet(Guid.NewGuid(), walletViewModel.UserId ,walletViewModel.CurrentValue, walletViewModel.Bank, DateTime.Now);

            _bankContext.Wallets.Add(wallet);
            _bankContext.SaveChangesAsync();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public List<Wallet> GetWalletsByUserId(Guid userId)
        {
            List<Wallet> wallets = _bankContext.Wallets
                .Where(x => x.UserId == userId)
                .ToList();

            return wallets;
        }
    }
}

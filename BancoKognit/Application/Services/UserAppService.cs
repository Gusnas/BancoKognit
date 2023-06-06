using BancoKognit.Application.ViewModels;
using BancoKognit.Domain.Models;
using BancoKognit.Infra.Context;
using System.Net;

namespace BancoKognit.Application.Services
{
    public class UserAppService
    {
        private readonly BankContext _bankContext;

        public UserAppService()
        {
            _bankContext = new BankContext();
        }

        public HttpResponseMessage Register(UserViewModel userViewModel)
        {
            if (userViewModel == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            var user = new User(Guid.NewGuid(), userViewModel.Name, userViewModel.BirthDate, userViewModel.CPF);

            _bankContext.Users.Add(user);
            _bankContext.SaveChangesAsync();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}

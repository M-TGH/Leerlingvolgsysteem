using Leerlingvolgsysteem.Models.Services.Database;
using Leerlingvolgsysteem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models.Services
{
    public class LoginService : DatabaseConnection
    {
        //<Author> Tim Prosé </Author>
        //Check if User Exists, if not return Error
        public AccountLoginViewModel LoginAccount(AccountLoginViewModel AccountData)
        {

            var AccountModel = new AccountLoginViewModel();

            var GetAccount = dbContext.Account.FirstOrDefault(us => us.userName == AccountData.userName && us.password == AccountData.password);

            if(GetAccount != null)
            {
                var AccountAuth = dbContext.AccountAuthorication.FirstOrDefault(us => us.UserId == GetAccount.Id);
                AccountModel.userId = GetAccount.Id;
                AccountModel.Error = false;
                AccountModel.Message = "You've successfully logged in!";
                AccountModel.AuthoricationId = GetAccount.authorication;
            }
            else
            {
                AccountModel.Error = true;
                AccountModel.Message = "Password and/or Username doesn't exists!";
            }
            return AccountModel;
        } 
    }
}
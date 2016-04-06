using Leerlingvolgsysteem.Models.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models.Services.AccountServices
{
    public class AccountService : DatabaseConnection
    {
        public AccountViewModel ShowProfile(int UserId)
        {
            var Account = dbContext.Account.FirstOrDefault(account => account.Id == UserId);
            var Output = new AccountViewModel
            {
                Id = UserId,
                name = Account.name,
                lastName = Account.lastName
            };
            return Output;
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Information
    {
        public List<Account> Accounts;

        public Information()
        { 
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 1, Name = "aaron neri", Age = 15 });
            Accounts.Add(new Account { Id = 2, Name = "john wall", Age = 16 });
            Accounts.Add(new Account { Id = 3, Name = "george smith", Age = 17 });
        }
    }
}
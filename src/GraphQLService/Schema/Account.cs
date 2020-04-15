using HotChocolate;
using System.Collections.Generic;

namespace GraphQLService.Schema
{

    public class AccountResponse
    {
        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        [GraphQLNonNullType]
        public string Code { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }

    public class Query
    {
        [GraphQLNonNullType]
        public IEnumerable<Account> GetAccounts()
        {
            var accounts = new List<Account>{
            new Account {
                Code = "1",
                Name = "Banks",
               Level = 1,
            },
            new Account {
                Code = "2",
                Name = "Suppliers",
               Level = 1,
            }
        };

            return accounts;
        }
    }
}




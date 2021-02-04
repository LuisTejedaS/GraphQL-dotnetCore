using System.Collections.Generic;
using HotChocolate.Types;
using GraphQLService.Schema;
namespace GraphQLService.Graphql
{

    [ExtendObjectType(Name = "Query")]
    public class AccountQueries
    {
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

    [ExtendObjectType(Name = "Mutation")]
    public class AccountMutations
    {
        public Account CreateAccount(Account inputAccount)
        {
            return inputAccount;
        }

    }


}




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



    public class Mutation
    {

        public Account CreateAccount(Account inputAccount)
        {
            return inputAccount;
        }
    }
}




using GraphQL.Client.Http;
using System;
using Xunit;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using System.Collections.Generic;

namespace GraphQLClient
{

    public class AccountResponse
    {
        public List<Account> Accounts { get; set; }
    }

    public class Account
    { 
        public string Code { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }

    public class UnitTest1
    {
        [Fact]
        public async System.Threading.Tasks.Task Test1Async()
        {
            var graphQLClient = new GraphQLHttpClient("https://localhost:44341/graphql", new NewtonsoftJsonSerializer());



            var request = new GraphQLRequest
            {
                Query = @"
                {
                   accounts{
                         name
                         code
                   }
                }"
            };
            var graphQLResponse = await graphQLClient.SendQueryAsync<AccountResponse>(request);

        }
    }
}

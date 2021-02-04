# GraphQL-dotnetCore

Example of use of GraphQL in .net core

Use to test in playground

query
{
accounts{
name
code
}
}

mutation

mutation {
createAccount(inputAccount:{
code: "sasdfdsfsf"
level: 4
name: "String"
}){
code
}
}

﻿using AdemCatamak.Api.Model;

namespace AdemCatamak.Api.Test.BasicAuthenticationTest
{
    public class AuthenticationChecker : IAuthenticationChecker
    {
        bool IAuthenticationChecker.Check(string userName, string password)
        {
            return userName == "adem" && password == "1";
        }
    }
}
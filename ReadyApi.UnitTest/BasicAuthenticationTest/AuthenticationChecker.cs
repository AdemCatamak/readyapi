﻿
using ReadyApi.Model;

namespace ReadyApi.UnitTest.BasicAuthenticationTest
{
    public class AuthenticationChecker : IAuthenticationChecker
    {
        bool IAuthenticationChecker.Check(string userName, string password)
        {
            return userName == "adem" && password == "1";
        }
    }
}
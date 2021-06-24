using System.Collections.Generic;
using Intalk.Configuration;

namespace Intalk.Models.DTOs.Responses
{
    /// <summary>
    /// This class contains the fields necessary to properly respond to a client's request to authenticate.
    /// This includes successful and failed attempts to authenticate.
    /// </summary>
    public class RegistrationResponse : AuthResult
    {
        public Dictionary<string, List<string>> Errors = new Dictionary<string, List<string>>(){
            {"email", new List<string>()},
            {"password", new List<string>()},
            {"username", new List<string>()},
            {"general", new List<string>()},
        };

        public class AuthErrors
        {
            public List<string> General = new List<string>();
            public List<string> Email = new List<string>();
            public List<string> Username = new List<string>();
            public List<string> Password = new List<string>();
        }
    }
}
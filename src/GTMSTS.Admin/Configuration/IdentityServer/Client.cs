using System.Collections.Generic;
using GTMSTS.Admin.Configuration.Identity;

namespace GTMSTS.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}







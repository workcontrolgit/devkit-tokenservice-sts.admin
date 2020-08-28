using GTMSTS.Shared.Configuration.Identity;
using GTMSTS.STS.Identity.Configuration.Interfaces;

namespace GTMSTS.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}






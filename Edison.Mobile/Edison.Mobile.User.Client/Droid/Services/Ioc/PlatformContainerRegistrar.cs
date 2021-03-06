using Autofac;
using Edison.Mobile.Common.Auth;
using Edison.Mobile.Common.Ioc;
using Edison.Mobile.User.Client.Droid.Shared;
using Microsoft.Identity.Client;

namespace Edison.Mobile.User.Client.Droid.Ioc
{
    public class PlatformContainerRegistrar : IContainerRegistrar
    {
        public void Register(ContainerBuilder builder)
        {
            var publicClientApplication = new PublicClientApplication(Constants.ClientId, AuthConfig.UserAuthority)
            {
                RedirectUri = AuthConfig.UserRedirectUri,
            };

            builder.RegisterInstance(publicClientApplication).As<IPublicClientApplication>();
        }
    }
}

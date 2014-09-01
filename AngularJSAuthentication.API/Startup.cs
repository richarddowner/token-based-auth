using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly : OwinStartup(typeof(AngularJSAuthentication.API.Startup))]
namespace AngularJSAuthentication.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthorizationServerOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthorizationServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }

    public class SimpleAuthorizationServerProvider : IOAuthAuthorizationServerProvider
    {
        public Task MatchEndpoint(OAuthMatchEndpointContext context)
        {
            throw new NotImplementedException();
        }

        public Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            throw new NotImplementedException();
        }

        public Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public Task ValidateAuthorizeRequest(OAuthValidateAuthorizeRequestContext context)
        {
            throw new NotImplementedException();
        }

        public Task ValidateTokenRequest(OAuthValidateTokenRequestContext context)
        {
            throw new NotImplementedException();
        }

        public Task GrantAuthorizationCode(OAuthGrantAuthorizationCodeContext context)
        {
            throw new NotImplementedException();
        }

        public Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            throw new NotImplementedException();
        }

        public Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            throw new NotImplementedException();
        }

        public Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {
            throw new NotImplementedException();
        }

        public Task GrantCustomExtension(OAuthGrantCustomExtensionContext context)
        {
            throw new NotImplementedException();
        }

        public Task AuthorizeEndpoint(OAuthAuthorizeEndpointContext context)
        {
            throw new NotImplementedException();
        }

        public Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            throw new NotImplementedException();
        }
    }
}
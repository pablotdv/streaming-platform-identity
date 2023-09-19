using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;

namespace IdentityServerAspNetIdentity;

public static class Config
{
    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope("streaming-api","Streaming Platform API")
            };

    public static IEnumerable<Client> Clients =>
        new Client[]
            {
                new Client {
                    ClientId = "streaming-api",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "streaming-api" },
                }
            };

    public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
    {
        new ApiResource("streaming-api", "Streaming API") { Scopes = { "streaming-api" } }
    };
}
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.Clamav.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareClamavOpenApiClientTests : HostedUnitTest
{
    public CloudflareClamavOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

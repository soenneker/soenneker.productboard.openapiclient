using Soenneker.Tests.HostedUnit;

namespace Soenneker.ProductBoard.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ProductBoardOpenApiClientTests : HostedUnitTest
{
    public ProductBoardOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

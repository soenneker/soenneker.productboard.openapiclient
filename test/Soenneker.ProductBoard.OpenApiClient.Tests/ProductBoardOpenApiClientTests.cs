using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ProductBoard.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ProductBoardOpenApiClientTests : FixturedUnitTest
{
    public ProductBoardOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

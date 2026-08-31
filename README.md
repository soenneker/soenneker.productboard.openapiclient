[![](https://img.shields.io/nuget/v/soenneker.productboard.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.productboard.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.productboard.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.productboard.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.productboard.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.productboard.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.productboard.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.productboard.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.ProductBoard.OpenApiClient

Generated request builders and models for Productboard API v2 notes, entities, members, teams, analytics, integrations, and webhooks.

## Installation

```bash
dotnet add package Soenneker.ProductBoard.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.ProductBoard.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", token);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.productboard.com/v2"
};

var client = new ProductBoardOpenApiClient(adapter);
var notes = await client.Notes.GetAsync(
    cancellationToken: cancellationToken);
```

The bearer token can be a Productboard personal API token or an OAuth access token. Workspace fields are configuration-driven, so integrations that create or update resources should query the corresponding configuration endpoints instead of assuming every workspace has the same fields.

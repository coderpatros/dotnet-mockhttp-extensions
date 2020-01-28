[![Build Status](https://dev.azure.com/coderpatros/OpenSource/_apis/build/status/CoderPatros.MockHttpExtensions?branchName=master)](https://dev.azure.com/coderpatros/OpenSource/_build/latest?definitionId=16&branchName=master)
![Azure DevOps tests](https://img.shields.io/azure-devops/tests/coderpatros/OpenSource/16.svg)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/coderpatros/OpenSource/16.svg)
[![CodeFactor](https://www.codefactor.io/repository/github/coderpatros/dotnet-mockhttp-extensions/badge)](https://www.codefactor.io/repository/github/coderpatros/dotnet-mockhttp-extensions)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/152d264f1e2f490c898b7dde0a5c7956)](https://www.codacy.com/manual/coderpatros/dotnet-mockhttp-extensions?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=coderpatros/dotnet-mockhttp-extensions&amp;utm_campaign=Badge_Grade)
[![NuGet](https://img.shields.io/nuget/v/CoderPatros.MockHttpExtensions.svg?style=flat-square)](https://www.nuget.org/packages/CoderPatros.MockHttpExtensions/)
![Nuget](https://img.shields.io/nuget/dt/CoderPatros.MockHttpExtensions.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions?ref=badge_shield)

# MockHttp Extensions

This library is a small collection of extension methods for Richard Szalay's
excellent [MockHttp](https://github.com/richardszalay/mockhttp). It targets
.net standard 2.0 and is
available via nuget as `CoderPatros.MockHttpExtensions`

Currently it only contains extensions for verifying the correct content type
and some json helpers.

## Notes about version 1.2

As of version `1.2.0` System.Text.Json is used instead of Newtonsoft.Json.

This won't affect the correctness of these extension methods. But may have
unforeseen issues with existing unit test data.

If this affects you please raise an issue. The only driver for this change is
to remove a non-standard library dependency. If it starts to cause people
grief I'll happily reinstate a maintained Newtonsoft.Json version.

## Extension Methods

    .WithContent(string contentType, string content)
    .WithJsonContent(string json)
    .WithJsonContent(object obj)

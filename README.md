[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build Status](https://dev.azure.com/coderpatros/OpenSource/_apis/build/status/Patros.MockHttpExtensions?branchName=master)](https://dev.azure.com/coderpatros/OpenSource/_build/latest?definitionId=16&branchName=master)
![Azure DevOps tests](https://img.shields.io/azure-devops/tests/coderpatros/OpenSource/16.svg)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/coderpatros/OpenSource/16.svg)
[![NuGet](https://img.shields.io/nuget/v/Patros.MockHttpExtensions.svg?style=flat-square)](https://www.nuget.org/packages/Patros.MockHttpExtensions/)
![Nuget](https://img.shields.io/nuget/dt/Patros.MockHttpExtensions.svg)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions?ref=badge_shield)

# MockHttp Extensions

This library is a small collection of extension methods for Richard Szalay's
excellent [MockHttp](https://github.com/richardszalay/mockhttp). It targets
.net standard 2.0 and is
available via nuget as `Patros.MockHttpExtensions`

Currently it only contains extensions for verifying the correct content type
and some json helpers.

### Extension Methods

    .WithContent(string contentType, string content)
    .WithJsonContent(string json)
    .WithJsonContent(object obj)


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-mockhttp-extensions?ref=badge_large)
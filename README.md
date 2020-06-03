[![Build Status](https://github.com/coderpatros/dotnet-mockhttp-extensions/workflows/.NET%20Core%20CI/badge.svg)](https://github.com/coderpatros/dotnet-mockhttp-extensions/actions?workflow=.NET+Core+CI)
[![NuGet](https://img.shields.io/nuget/v/CoderPatros.MockHttpExtensions.svg?style=flat-square)](https://www.nuget.org/packages/CoderPatros.MockHttpExtensions/)
![Nuget](https://img.shields.io/nuget/dt/CoderPatros.MockHttpExtensions.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
![Twitter Follow](https://img.shields.io/twitter/follow/coderpatros?style=social)

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

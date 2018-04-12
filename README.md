[![NuGet](http://img.shields.io/nuget/v/Patros.MockHttpExtensions.svg?style=flat-square)](https://www.nuget.org/packages/Patros.MockHttpExtensions/)

![Build status](https://patros.visualstudio.com/_apis/public/build/definitions/aeeb85d1-1700-4998-aceb-007132d507d1/10/badge)

# MockHttp Extensions

This library is a small collection of extension methods for Richard Szalay's
excellent [MockHttp](https://github.com/richardszalay/mockhttp). It targets
.net standard 2.0 (although in theory could target 1.1 if required) and is
available via nuget as `Patros.MockHttpExtensions`

Currently it only contains extensions for verifying the correct content type
and some json helpers.

### Extension Methods

    .WithContent(string contentType, string content)
    .WithJsonContent(string json)
    .WithJsonContent(object obj)
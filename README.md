[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build Status](https://dev.azure.com/patros/OpenSource/_apis/build/status/Patros.MockHttpExtensions?branchName=master)](https://dev.azure.com/patros/OpenSource/_build/latest?definitionId=16&branchName=master)
![Azure DevOps tests](https://img.shields.io/azure-devops/tests/patros/OpenSource/16.svg)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/patros/OpenSource/16.svg)
[![NuGet](https://img.shields.io/nuget/v/Patros.MockHttpExtensions.svg?style=flat-square)](https://www.nuget.org/packages/Patros.MockHttpExtensions/)

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

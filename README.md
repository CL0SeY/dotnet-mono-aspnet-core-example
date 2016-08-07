# .NET Core 1.0 (RTM) Example App (.NET 4.5.1 Framework using Docker + Mono)

## Build + run
```
> docker build -t dotnet-mono-aspnet-core-example .
> docker run -it -p 5000:5000 dotnet-mono-aspnet-core-example
```
And then browse to your docker host on port 5000.

## Why?
This example can serve as a starting point for those people who still have .NET 4.5.1 dependencies but want to use ASP.NET Core in Docker.

## How do I know this is using .NET 4.5.1?
It has a dependency on RestSharp 105.2.3, which is not .NET Core compatible. An example REST response from http://jsonplaceholder.typicode.com/posts is shown on the home page.

## Docker base image
[cl0sey/dotnet-mono-node-docker](https://hub.docker.com/r/cl0sey/dotnet-mono-node-docker) in order to get the node + git dependency so that we can install things with bower.
See the parent image [cl0sey/dotnet-mono-docker](https://hub.docker.com/r/cl0sey/dotnet-mono-docker) for more information.

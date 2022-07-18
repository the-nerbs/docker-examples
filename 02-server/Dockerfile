# This Dockerfile is much the same as in example 1 (console app), but we're
# now dealing with a larger framework in ASP.NET, which pulls in a number of
# nuget packages. Throughout the file, changes made to take advantage of
# docker's layer cache will be explained below.
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /src

# The project file doesn't change too often with .NET's new SDK format,
# so before we restore, we can copy just the project file into the image.
# This means that all steps up to copying in the source can be cached for
# reuse later, which means that we won't have to wait for the restore every
# time we build.
COPY "ServerApp.csproj" .

RUN dotnet restore "ServerApp.csproj"


# Now that we have our nuget packages restored, we can copy everything else
# into the image. If all that changed was a source file, everything before now
# will have been cached and the build will pick up from here.
COPY . .

# Add `--no-restore` to the build command line here so we use the nuget
# packages from our cached image. We also don't set a special output path
# here since web projects typically have an additional publish step later,
# and we want the outputs from *that* step instead for our final image.
RUN dotnet build "ServerApp.csproj" --no-restore

RUN dotnet publish "ServerApp.csproj" --no-build -o /app/publish


# Since we're running an ASP.NET project, we need to use the ASP.NET image
# as our final execution environment.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as final
WORKDIR /app
EXPOSE 80

COPY --from=build /app/publish .

ENTRYPOINT [ "/app/ServerApp" ]
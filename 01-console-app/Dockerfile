# Start working in an environment suitable for building.
# Microsoft provides base images for many configurations of .NET, including
# permutations of each supported runtime version and each supported platform
# (Windows, various Linux distros).
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# set the working directory for our build environment
WORKDIR /src

# copy everything from our context into the image's working directory
COPY . .

# and build our project
# we set the output directory (using -o) to a known location for use later on
RUN dotnet build console-app.csproj -o /app/build


# Start working in a new, clean environment for running the application
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS final
WORKDIR /app

# Copy the build outputs from our build environment.
COPY --from=build /app/build .

# When we start up a container using this image, run this command by default.
# this can be overidden on when running the `docker run` command using the
# `--entrypoint` argument
ENTRYPOINT [ "/app/console-app" ]

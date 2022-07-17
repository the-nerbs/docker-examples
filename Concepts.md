This page aims to describe the parts of docker you'll encounter, and how they
work together.

:warning: This page is a work-in-progress. Some sections are listed below, but not yet filled in.

Contents:
- [Dockerfiles](#dockerfiles)
  - [Build context](#build-context)
- [Images](#images)
  - [Repositories and Tags](#repositories-and-tags)
  - [Registry](#registry)
- [Containers](#containers)
- [Networks](#networks)
- [Volumes](#volumes)
  - [Bind mounts](#bind-mounts)


# Dockerfiles
## Build context

# Images

Images are one of the core object types in the docker ecosystem. They
represent the at-rest state of a docker container. Comparing docker to a
traditional virtual machine, an images is similar to a snapshot.

Images are created using the `docker build` command, based on a
[Dockerfile](#dockerfiles). They can be identified either by their image ID,
which is a hash over part of the image's contents, or by a repository and
optionally a tag.


## Repositories and Tags

A image's repository and tag combine to form a descriptive name for an image.
These are combined in the form `repository:tag`.

The repository acts as the name of an image, describing what its purpose may
be or what is on the image. When needed, a hierarchy can be established using
forward slash (`/`) separators.

The tag is used for versioning. For example, a single repository may contain
images tagged `1.0`, `1.1`, and `1.2`. Multiple tags can also
reference the same image, so you may also see a single image with a list of
tags like `1`, `1.0`, and `latest`. When referencing such an image, you could
reference just the `1` tag to always use that major version, or `1.0` to be
locked to major and minor version. Note that containers can not update their
base images while running, so if you reference tag `1` and start the container
as version 1.0, and then a new version 1.1 is published, you would only pull
that new version when you create the container again.

The `latest` tag is a bit special to docker, as it is the default used when no
tag is specified. For example, the command line `docker start my-container` is
the same as `docker start my-container:latest`.

When an image is pulled from [an image registry](#registry) other than
docker's own [Docker hub](https://hub.docker.com), the repository will be
prefixed with the domain name of the registry the image was pulled from. For
example, when you pull the `dotnet/sdk` image from Microsoft's registry, it
will be pulled as `mcr.microsoft.com/dotnet/sdk`.


## Registry

A registry is a server used to store built docker images. Docker hosts a
first-party registry at [Docker Hub](https://hub.docker.com). If an image
cannot be found locally, docker will also search Docker Hub.

A private registry can also be hosted as a container using dockers official
`registry` image.


# Containers
# Networks
# Volumes
## Bind mounts
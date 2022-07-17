Terminology
-----------------------------------------------------------

Coming from the world of desktop application development, there's a lot of
jargon around Docker that may make it seem wholly incomprehensible at first.
Worry not, though! While Docker does have some concepts that need new terms
for technical accuracy, most of them will have close analogues with
technologies you're probably already be familiar with.


Below is a list of some of the new terminology you are likely to encounter.


| Term       | Definition |
|:-----------|:-----------|
| Bind mount | One of the mechanisms for providing files to a docker container. Shares a file or directory from the host with a container. See [the docker concepts](#bind-mounts) section for more details. |
| Container  | The isolated environment in which an application is run under docker. See [the docker concepts](#containers) section for more details. |
| Dockerfile | A file which describes how to build a docker image. Effectively a build script for a docker image.|
| Image      | A snapshot of a container's state. See [the docker concepts](#images) section for more details. |
| Registry   | A server from which you can pull pre-built docker images. This is similar to a package feed such as nuget.org for .NET or PyPI for python's pip. |
| Repository | A human-readable name for a group of related images. Images within a repository are further distinguished by their tags. |
| Tag        | Used to distinguish between image variants within a repository. Conventionally indicates a version number and potentially a platform moniker, such as `5.0` or `5.0-ubuntu`. |

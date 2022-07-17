Command line quick reference
-----------------------------------------------------------

This file provides a few helpful command lines that you may want ot use
frequently.


# Help commands

## --help

More important than any complete command is the `--help` argument. When you
have any questions about which commands are available or how to use them, then
you can append `--help` to your `docker` command to get more information.

`docker --help` will show you which commands are available, as well as a
handful of arguments that affect how commands are run.

`docker <command> --help` (example: `docker build --help`) will print the
usage, a brief description, and all the arguments the command takes.

## (Linux) man

Most Linux distributions provide the `man` tool which allows you to view
reference manuals for other tools installed on your system. This often
includes more detailed information than is included with the `--help` output.

To view the manual for the `docker` cli itself, you can run `man docker`.
Each command also has its own manuals that are named like `docker-<command>`.
For example, you can see the manual for `docker build` by running
`man docker-build`.

You can also search the available manuals by title by running
`apropos <search term>`, or `man -k <search term>` if `apropos` is not
available.


# Docker Commands

- `docker images`<br/>
  `docker image list`<br/>
  Lists images on the local system. Add `--all`/`-a` to also list intermediate
  images created as part of building.

- `docker image prune`<br/>
  Deletes unused images. Add `--force`/`-f` to not prompt for confirmation.

- `docker ps`<br/>
  Lists the running containers. Add `--all`/`-a` to also list stopped
  containers.

- `docker rmi <image id>`<br/>
  Removes the referenced image.

- `docker run <image id>`<br/>
  Starts a container from the referenced image using its default entry
  point.

- `docker run -it --entrypoint /bin/bash <image id>`<br/>
  Starts an interactive container to a bash prompt. Useful for inspecting a
  container's state. Notably, when a `docker build` command fails, this can be
  used to inspect the intermediate image's state to diagnose the issue.

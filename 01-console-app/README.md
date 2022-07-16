# Docker Example 1 - A simple command line tool

This example project demonstrates how you can create and run a command line
tool using dotnet and docker.

For this example, we have a small interactive tool which simply takes two
numbers and outputs their sum. Our tool's code is written in C#, and is all
contained in [Program.cs](./Program.cs) in this directory.


# Building the Container

From your terminal, navigate to this directory and run the following command:
```
docker build --tag console-app .
```

This will build a docker image which is ready to run the application. This
command has a few parts:
- `docker build` is the command to build a docker image.

- `--tag console-app` provides a name for our built image, `console-app` in
  this example. `--tag` also has the short form `-t`.

- The `.` at the end tells docker which directory to use as the build context;
  which files are available to the image being built.

Since our Dockerfile is in the same directory we use as the build context,
docker will use it automatically. If you want to use a Dockerfile that exists
in a different directory, then you can point to it using the `--file` argument
(or its short form `-f`) as such:
```
docker build -t console-app --file ./DockerFile .
```

When run from this directory, this command produces the same results as our
previous command.


# Running the Tool

From your terminal, run the following command:
```
docker run --interactive console-app
```

Once you have built the docker image the result is stored in a local registry,
so you don't need to be in any specific directory when you run it. After
running this command, you will see some output and an input prompt from our
tool.

Similar to our build command, the run command has three parts:
- `docker run` is the docker command to create a new container

- `--interactive` (or its short form `-i`) creates the container in an
  interactive mode, making it so that your terminal's stdin and stdout streams
  are tied to the container.

- `console-app` is the name we gave our image earlier when building.


# When should you do this?

Rarely.

Running console tools in a docker container provides little benefit. However,
there are a few aspects of containers that may make it a worthwhile endeavor:

1. Docker containers offer a standardized execution environment. This means
   that there is nothing extra in the environment that could impact how it
   runs, at least not without taking extra steps when starting the container.
   This can make containerization a decent solution when reproducibility or
   determinism are desired.

2. The ephemeral nature of docker containers can also make them a decent
   solution for automated processes where you don't need the environment to
   persist after execution. For example, many CI build services allow you to
   run builds inside one or more docker containers, including Appveyor,
   Microsoft's Azure Pipelines, and Atlassian's Bamboo.

3. Docker containers can allow Windows developers to run Linux tools. However,
   using WSL is usually going to provide a better experience as it is a
   complete Linux environment that persists across executions without any
   extra work.


Another consideration that goes into whether to containerize a tool like this
is that docker itself is not a tool that an average end-user is likely to be
familiar with, and most users will be made *very* uncomfortable being told to
install an unfamiliar application and running random command lines. Because of
this, containerization is a solution more geared towards developers and system
administrators who are already familiar with command line terminals.


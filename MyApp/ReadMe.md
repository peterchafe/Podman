## Dotnet Application.

- Create Console application

    `dotnet new console -o MyApp`

- Make the necessary changes to the code.
- Publish the application

    `dotnet publish -c Release`

---

## Podman

### Pull ubuntu latest.
`podman pull ubuntu:latest`

### Build from Published image.
`podman build -t ubuntu-dev -f Dockerfile .`

### Execute and then remove container.
`podman run -it --rm ubuntu-dev 2`

### Run with bash interactively.
`podman run -it --rm --entrypoint bash ubuntu-dev`
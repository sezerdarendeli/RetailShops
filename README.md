# RetailShops 
It is a project that provides RestFull api services developed with .Net Core, which calculates the discount of the chain store.

## Installation and Launch
RetailShops requires [.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-3.1.416-windows-x64-installer) 

#### For Visual Studio
1. Clone the repository.
2. Install Requires .Net Core 3.1 
3. Visual Studio in Simply open the solution file ShopsRUs.sln 
4. After getting solution build Start RetailShops.API project. 

##### Migration
Package Manager Console (Visual Studio)
```sh
Update-Database
```
For Command Line/CLI (Visual Studio Code)
```sh
dotnet ef database update
```
## Features
1. If the user is an employee of the store, he gets a 30% discount
2. If the user is an affiliate of the store, he gets a 10% discount
3. If the user has been a customer for over 2 years, he gets a 5% discount.
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45 as a discount).
5. The percentage based discounts do not apply on groceries.
6. A user can get only one of the percentage based discounts on a bill

## Technology
RetailShops uses a number of Libraries, structer and patterns:

- [Entity Framework] - used Entity Framework Core.
- [DDD] -Domain Drive Design implementation in a .NET Core.
- [DI] - Dependcy Injection for Microsoft.Extensions.DependencyInjection.
- [Repository Pattern] - Implementing Repository Pattern In ASP.NET Core 3.1.
- [Mapper] -used AutoMapper library.
- [Mediatr] - Mediatr pattern implementation in a .NET Core
- [Swagger] - Implementing Swagger UI 
 

## Plugins

Dillinger is currently extended with the following plugins.
Instructions on how to use them in your own application are linked below.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Development

Want to contribute? Great!

Dillinger uses Gulp + Webpack for fast developing.
Make a change in your file and instantaneously see your updates!

Open your favorite Terminal and run these commands.

First Tab:

```sh
node app
```

Second Tab:

```sh
gulp watch
```

(optional) Third:

```sh
karma test
```

#### Building for source

For production release:

```sh
gulp build --prod
```

Generating pre-built zip archives for distribution:

```sh
gulp build dist --prod
```

## Docker

Dillinger is very easy to install and deploy in a Docker container.

By default, the Docker will expose port 8080, so change this within the
Dockerfile if necessary. When ready, simply use the Dockerfile to
build the image.

```sh
cd dillinger
docker build -t <youruser>/dillinger:${package.json.version} .
```

This will create the dillinger image and pull in the necessary dependencies.
Be sure to swap out `${package.json.version}` with the actual
version of Dillinger.

Once done, run the Docker image and map the port to whatever you wish on
your host. In this example, we simply map port 8000 of the host to
port 8080 of the Docker (or whatever port was exposed in the Dockerfile):

```sh
docker run -d -p 8000:8080 --restart=always --cap-add=SYS_ADMIN --name=dillinger <youruser>/dillinger:${package.json.version}
```

> Note: `--capt-add=SYS-ADMIN` is required for PDF rendering.

Verify the deployment by navigating to your server address in
your preferred browser.

```sh
127.0.0.1:8000
```

## License

MIT

**Free Software, Hell Yeah!**

[//]: # 

[DI]: <https://www.c-sharpcorner.com/article/dependency-injection-in-net-core&.>
[Entity Framework]: <https://www.entityframeworktutorial.net/.>
[Repository Pattern]: <https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/.>
[DDD]: <https://enlabsoftware.com/development/domain-driven-design-in-asp-net-core-applications.html#:~:text=The%20architecture%20of%20DDD%20projects,separate%20them%20into%20different%20layers.>
[Mediatr]: <https://code-maze.com/cqrs-mediatr-in-aspnet-core/.>
[Mapper]: <https://code-maze.com/automapper-net-core/.>
[Swagger]: <https://github.com/domaindrivendev/Swashbuckle.AspNetCore.>


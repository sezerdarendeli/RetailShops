[![Build](https://github.com/sezerdarendeli/RetailShops/actions/workflows/build.yml/badge.svg)](https://github.com/sezerdarendeli/RetailShops/actions/workflows/build.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=sezerdarendeli_RetailShops&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=sezerdarendeli_RetailShops)
# RetailShops 
It is a project that provides RestFull api services developed with .Net Core, which calculates the discount of the chain store.

## Features
1. If the user is an employee of the store, he gets a 30% discount
2. If the user is an affiliate of the store, he gets a 10% discount
3. If the user has been a customer for over 2 years, he gets a 5% discount.
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45 as a discount).
5. The percentage based discounts do not apply on groceries.
6. A user can get only one of the percentage based discounts on a bill

## Installation and Launch
RetailShops requires [.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-3.1.416-windows-x64-installer) 

### For Visual Studio
1. Clone the repository.
2. Install Requires .Net Core 3.1 
3. Visual Studio in Simply open the solution file ShopsRUs.sln 
4. After getting solution build Start RetailShops.API project. 

### For Visual Studio Code
1. Clone the repository.
2. run dontnet restore/

##### Migration
Package Manager Console (Visual Studio)
```sh
Update-Database
```
For Command Line/CLI (Visual Studio & Visual Studio Code)
```sh
dotnet ef database update
```

## Technology
RetailShops uses a number of Libraries, structer and patterns:

- [Entity Framework] - used Entity Framework Core.
- [DDD] -Domain Drive Design implementation in a .NET Core.
- [DI] - Dependcy Injection for Microsoft.Extensions.DependencyInjection.
- [Repository Pattern] - Implementing Repository Pattern In ASP.NET Core 3.1.
- [Mapper] -used AutoMapper library.
- [Mediatr] - Mediatr pattern implementation in a .NET Core
- [Swagger] - Implementing Swagger UI 
- [xUnit] - Unit test for xUnit project in write Unit Test Code.
- [Moq] - Unit test in used
- [SonarQube] - Code quaility for local in Docker SonarQube platform created.
- [SonarLint]- For used Code quailty in Visual Studio


## Unit Test Covarage Results
![Unit Test Covarage Results](https://raw.githubusercontent.com/sezerdarendeli/RetailShops/master/unittestcovarage.PNG)

## Project Documentation
>UML Class Diagram
![UML Class Diagram](https://raw.githubusercontent.com/sezerdarendeli/RetailShops/master/UMLClass.png)

![Swagger UI](https://raw.githubusercontent.com/sezerdarendeli/RetailShops/master/swagger.PNG)


## License
**Free Software,personal development project

[//]: # 

[DI]: <https://www.c-sharpcorner.com/article/dependency-injection-in-net-core&.>
[Entity Framework]: <https://www.entityframeworktutorial.net/.>
[Repository Pattern]: <https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/.>
[DDD]: <https://enlabsoftware.com/development/domain-driven-design-in-asp-net-core-applications.html#:~:text=The%20architecture%20of%20DDD%20projects,separate%20them%20into%20different%20layers.>
[Mediatr]: <https://code-maze.com/cqrs-mediatr-in-aspnet-core/.>
[Mapper]: <https://code-maze.com/automapper-net-core/.>
[Swagger]: <https://github.com/domaindrivendev/Swashbuckle.AspNetCore.>
[xUnit]: https://github.com/CodeMazeBlog/testing-aspnetcore-mvc.>
[Moq]: https://www.thecodebuzz.com/unit-test-mock-automapper-asp-net-core-imapper/.>


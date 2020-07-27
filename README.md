# IQ Test
IQ Test Application developed with ASP.NET Core and Angular

Technologies and libraries used:
- [.NET Core 3.1 (platform)](https://github.com/dotnet/core)
- [ASP.NET Core 3.1](https://github.com/dotnet/aspnetcore)
- [Entity Framework Core 3.1](https://github.com/dotnet/efcore)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
- [Angular 10](https://github.com/angular/angular)
- [Bootstrap 4.5](https://github.com/twbs/bootstrap)
- [FontAwesome](https://github.com/FortAwesome/Font-Awesome)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)
- [SendGrid](https://github.com/sendgrid/sendgrid-csharp)
- [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)

## Prerequisites
In order to run the application, you must have the following prerequisites installed on your machine:
- [.NET Core](https://dotnet.microsoft.com/download) (Version 3.1)
- [NodeJS](https://nodejs.org/en/) (Version 12.16.1 or higher)

## Running the application

### Running the server API
1. Restore the NuGet packages
2. Open the appsettings.Development.json file and set the database connection string, JWT secret key and SendGrid API key
3. Run the migrations to update the database
4. Run the application. It should start listening at http://localhost:50919/

### Running the web client
1. Navigate to the folder in cmd and install the packages with  `npm install`
2. Run `npm start` or `ng serve`. It should start listening at http://localhost:4200/

## Preview
You can find screenshots of the website in the [preview folder](/preview/)

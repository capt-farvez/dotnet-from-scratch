Have to install:
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
```

Run Migrations and Test
```
dotnet ef migrations add InitialCreate 

dotnet ef database update

dotnet run

```

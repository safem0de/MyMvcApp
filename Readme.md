```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
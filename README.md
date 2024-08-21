## To maintain stuffs install the necessary packages
<li>Dot Net Core 7</li>
<li>AutoMapper</li>
<li>Microsoft.EntityFrameworkCore 7.0.0</li>
<li>Microsoft.VisualStudio.Web.CodeGeneration.Design 7.0.0</li>
<li>Microsoft.EntityFrameworkCore.Design 7.0.0</li>
<li>Microsoft.VisualStudio.Web.CodeGenerators.Mvc 7.0.0</li>
<li>Npgsql.EntityFrameworkCore.PostgreSQL 7.0.0</li>
<li>Npgsql.EntityFrameworkCore.PostgreSQL.Design</li>

## Database
To make sure Database gets created, use migration in PostgreSQL password = `root` Username = `postgres`.<br> 
Check with the file `appsettings.json`<br>
Commands<br>
`dotnet ef migrations add InitialCreate`<br>
`dotnet ef database update`<br>
This will create database in postgreSQL

# 034_JWT_Authentication_login_and_role_based_custom_authentica

> Login And Role Based Custom Authentication In ASP.NET Core 3.1
- https://www.c-sharpcorner.com/article/login-and-role-based-custom-authentication-in-asp-net-core-3-1/

> Add EntityFramework with MySql
	- dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.3
		- Esta ya tiene dependencia para Microsoft.EntityFrameworkCore.Relational 5.0.10
			- Esta ya tiene dependencia para Microsoft.EntityFrameworkCore 5.0.10
			
	- dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
	
	- Add DbSet
		- Create Models/UserTests.cs
			namespace LoginDemo.Models
			{
				public class UserTest
				{
					public int Id { get; set; }
					public string Name { get; set; }
					public string Email { get; set; }
					public string Password { get; set; }
				}
			}
		- Add to Data/ApplicationDbContext.cs
			- public DbSet<UserTest> UserTests { set; get; }

	- Add connectionString to appsettings.json
		"ConnectionStrings": {
			"Default": "server=localhost,3306; user=root;password=123456;database=yt_csharp_auth_dos"
		}
		
	- Add use MySql to "Startup.cs/ConfigureServices"
		var sqlConnectionString = Configuration.GetConnectionString("Default");
	
		//var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
		var serverVersion = ServerVersion.AutoDetect(sqlConnectionString);
	
		services.AddDbContext<ApplicationDbContext>(
			options => options
				.UseMySql(sqlConnectionString, serverVersion)
		);
				
	- Migration
		- dotnet build
		- dotnet ef get-help about_entityframeworkcore
		- dotnet ef migrations add CreateUserTestsTable
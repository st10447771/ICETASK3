# ICETASK3
In order to allow this app to connect to a local server, you need to navigate to the appsettings.json file
and set the connection string to point to your local SQL Server Instance.
 If you're using SQL Authentication you could follow this template:
	"DefaultConnection": "Server=localhost;Database=StudentDb;User Id=sa;Password=YourPassword;"
And make sure to register the DbContext in Program.cs:

"builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));"
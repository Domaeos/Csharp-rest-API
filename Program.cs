using MyRestApi.Services;

Services.AddScoped<IDbService, DbService>();
Services.AddScoped<IEmployeeService, EmployeeService>()
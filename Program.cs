var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// mvc
// rest api
// razor pagess

// {controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute();

// same with app.MapDefaultControllerRoute();
// but its editable
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Meeting}/{action=Index}/{id?}"
);

app.Run();

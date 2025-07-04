using TodoList.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5082/") }); // เป็นการเชื่อมหน้าบ้านหลังบ้าน
// builder.Services.AddHttpClient("BackEnd", client =>
// {
//     client.BaseAddress = new Uri("http://172.16.200.202:8089/");
// });

builder.Services.AddHttpClient("BackEndCar", client =>
{
    client.BaseAddress = new Uri("http://localhost:5082/");
});



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

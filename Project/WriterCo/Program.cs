using WriterCo.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var url = builder.Configuration["Supabase:Url"]!;
var key = builder.Configuration["Supabase:Key"]!;

// 3. Register the Supabase Client BEFORE builder.Build()
builder.Services.AddSingleton<Supabase.Client>(sp => 
{
    return new Supabase.Client(url, key, new Supabase.SupabaseOptions 
    { 
        AutoConnectRealtime = false 
    });
});
// Add this line before builder.Build()
builder.Services.AddSingleton<UserSession>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scope = app.Services.CreateScope())
{
    var supabase = scope.ServiceProvider.GetRequiredService<Supabase.Client>();
    await supabase.InitializeAsync();
}
app.Run();

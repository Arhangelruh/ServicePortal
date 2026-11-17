using NLog;
using NLog.Web;
using Portal.Components;
using Portal.Services;
using ServicePortal.UI.Models;

var logger = LogManager.Setup()
	.LoadConfigurationFromAppSettings()
	.GetCurrentClassLogger();
try
{

	var builder = WebApplication.CreateBuilder(args);

	// Add services to the container.
	builder.Services.AddRazorComponents()
		.AddInteractiveServerComponents();

	builder.Services.AddSingleton<NavigationService>();
	builder.Services.AddScoped<AppShellState>();

	var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (!app.Environment.IsDevelopment())
	{
		app.UseExceptionHandler("/Error", createScopeForErrors: true);
		app.UseHsts();
	}
	app.UseStatusCodePagesWithReExecute("/NotFound", createScopeForStatusCodePages: true);
	app.UseHttpsRedirection();
	app.UseStaticFiles();
	app.UseAntiforgery();

	app.MapRazorComponents<App>()
		.AddInteractiveServerRenderMode();

	app.Run();

}
catch (Exception ex)
{
	logger.Error(ex, "Application stopped due to exception");
	throw;
}
finally
{ LogManager.Shutdown(); }
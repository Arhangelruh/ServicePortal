using ServicePortal.UI.Models;

namespace Portal.Services
{
	public sealed class NavigationService(IConfiguration configuration)
	{

		public List<NavigationItem> Services { get; } = configuration.GetSection("Services").Get<List<NavigationItem>>() ?? [];
	}
}

namespace ServicePortal.UI.Models
{
	public class AppShellState
	{
		/// <summary>
		/// Application name.
		/// </summary>
		public string ApplicationName { get; set; } = string.Empty;

		/// <summary>
		/// Application logo.
		/// </summary>
		public string? ApplicatinLogo { get; set; }

		/// <summary>
		/// Services.
		/// </summary>
		public List<NavigationItem> NavigationItems { get; set; } = [];

		/// <summary>
		/// Active application.
		/// </summary>
		public string? ActiveItem { get; set; }

	}
}

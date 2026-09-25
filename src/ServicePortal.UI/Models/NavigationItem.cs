namespace ServicePortal.UI.Models
{
	public class NavigationItem
	{
		/// <summary>
		/// Service Id.
		/// </summary>
		int Id { get; set; }

		/// <summary>
		/// Service name.
		/// </summary>
		public string? Name { get; set; }

		/// <summary>
		/// Service url.
		/// </summary>
		public string? Url { get; set; }

		/// <summary>
		/// Service ico.
		/// </summary>
		public string? Icon { get; set; }
	}
}

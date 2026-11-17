namespace ServicePortal.UI.Models
{
	public sealed class ErrorPageModel
	{
		public int? StatusCode { get; set; }

		public string Title { get; set; } = "Произошла ошибка.";

		public string Message { get; set; } = "При обработке запроса произошла ошибка.";
	}
}

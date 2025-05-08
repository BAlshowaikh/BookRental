namespace WebApp.ViewModel
{
	public class RentalRedirectDataViewModel
	{
		public string BookName { get; set; }

		public string UserName { get; set; }

		public DateTime? RentalStartDate { get; set; }

		public DateTime? ReturnDate { get; set; }

		public decimal TotalCost { get; set; }
	}
}

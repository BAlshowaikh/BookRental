namespace WebApp.ViewModel
{
	public class RentalRedirectDataViewModel
	{
		public int BookId { get; set; }

		public int UserId { get; set; }

		public DateTime? RentalStartDate { get; set; }

		public DateTime? ReturnDate { get; set; }

		public decimal TotalCost { get; set; }
	}
}

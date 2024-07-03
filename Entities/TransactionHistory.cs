namespace deposit_app.Entities
{
	public class TransactionHistory
	{
		public Guid Id { get; set; }
		public Guid DepositId { get; set; }
		public Guid TransactionType { get; set; }
		public string TransactionTypeNamed { get; set; }
		public DateTime DateTime { get; set; }
		public decimal Amount { get; set; }
		public decimal AmountBefore { get; set; }
		public decimal AmountAfter { get; set; }
	}
}

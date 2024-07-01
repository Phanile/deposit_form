namespace deposit_app.Entities
{
	public class DepositType
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Rate { get; set; }
		public bool Removable { get; set; }
		public bool Addable { get; set; }
		public decimal MinBalance { get; set; }
		public decimal MaxBalance { get; set; }
		public short TimeFrame { get; set; }
		public decimal NonDeductibleBalance { get; set; }
	}
}

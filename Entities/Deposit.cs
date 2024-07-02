using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposit_app.Entities
{
    internal class Deposit
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string DepositType { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string PersonalAccount { get; set; }
        public decimal InitialBalance {  get; set; }
        public decimal CurrBalance {  get; set; }
        public DateTime OpenDate {  get; set; }
        public DateTime? CloseDate { get;set; }
        public short TimeFrame {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposit_app.Entities
{
    internal class Deposit
    {
        public Guid id { get; set; }
        public Guid client_id { get; set; }
        public string deposit_type { get; set; }
        public string currency { get; set; }
        public string status { get; set; }
        public string personal_account { get; set; }
        public decimal initial_balance {  get; set; }
        public decimal curr_balance {  get; set; }
        public DateTime open_date {  get; set; }
        public DateTime? close_date { get;set; }
        public short timeframe {  get; set; }
    }
}

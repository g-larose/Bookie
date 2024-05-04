using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookie.Data.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public Guid? AcctNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long AcctTotal { get; set; }
        public DateTime? DepositedAt { get; set; }
        
    }
}

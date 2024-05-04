using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookie.Data.Models
{
    public class ServerMember
    {
        public int Id { get; set; }
        public string? ServerId { get; set; }
        public string? MemberId { get; set; }
        public string? MemberName { get; set; }
        public bool? IsOwner { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? JoinedAt { get; set; }
        public Wallet? Wallet { get; set; }
        public int WalletId { get; set; }
        public Bank? Bank { get; set; }
        public int BankId { get; set; }

    }
}

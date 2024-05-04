using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookie.Data.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public uint? Balance { get; set; }
        public DateTime? LastCommunity { get; set; }
        public DateTime? LastDaily { get; set; }
        public DateTime? LastChores { get; set; }
        public DateTime? LastHobby { get; set; }
        public DateTime? LastWork { get; set; }
        public DateTime? LastRob { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookie.Data.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public DateTime? Week { get; set; }
        public DateTime? Year { get; set; }
        public DateTime? GameDate { get; set; }
        public Team? AwayTeam { get; set; }
        public Team? HomeTeam { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookie.Data.Models
{
    public class Team
    {
        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public string? Name { get; set; }
        public string? Division { get; set; }
        public string? Record { get; set; }
        public string? Abr { get; set; }
        public string? LogoUrl { get; set; }
        public int? Score { get; set; }
        public bool? IsWinner { get; set; }

    }
}

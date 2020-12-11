using System;
using System.Collections.Generic;

namespace FinalBugTracker.Models
{
    public class TicketPriority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // nav
        public virtual ICollection<Ticket> Tickets { get; set; }
        public TicketPriority()
        {
            Tickets = new HashSet<Ticket>();
        }
    }
}

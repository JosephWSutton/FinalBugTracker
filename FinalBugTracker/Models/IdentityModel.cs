using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FinalBugTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DisplayName { get; set; }

            [NotMapped]
            public string FullName
            {
                get
                {
                    return $"{LastName}, {FirstName}";
                }
            }

            [NotMapped]
            public string FullNameWithEmail
            {
                get
                {
                    return $"{LastName}, {FirstName} - {Email}";
                }
            }

            // nav
            public virtual ICollection<Project> Projects { get; set; }
            public virtual ICollection<TicketAttachment> TicketAttachments { get; set; }
            public virtual ICollection<TicketComment> TicketComments { get; set; }
            public virtual ICollection<TicketHistory> TicketHistories { get; set; }
            public virtual ICollection<ToDo> ToDoes { get; set; }
            public ApplicationUser()
            {
                Projects = new HashSet<Project>();
                TicketAttachments = new HashSet<TicketAttachment>();
                TicketComments = new HashSet<TicketComment>();
                TicketHistories = new HashSet<TicketHistory>();
                ToDoes = new HashSet<ToDo>();

            }
        }
    }
}

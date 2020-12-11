using System;
using System.ComponentModel.DataAnnotations;

namespace FinalBugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }                    // Id number of the ticket

        [Required(ErrorMessage = "Project is required.")]
        [Display(Name = "Project")]
        public int ProjectId { get; set; }             // Foreign Key - Project the ticket belongs to

        [Required(ErrorMessage = "Ticket Type is required.")]
        [Display(Name = "Type")]
        public int TicketTypeId { get; set; }          // Foreign Key - Type of ticket: Defect, Documentation, Enhancement

        [Required(ErrorMessage = "Ticket Priority is required.")]
        [Display(Name = "Priority")]
        public int? TicketPriorityId { get; set; }     // Foreign Key - Priority of ticket: Low, Medium, High, Urgent

        [Display(Name = "Status")]
        public int TicketStatusId { get; set; }        // Foreign Key - Status of ticket: Inactive, Active/Unassigned, Active/Assigned, Completed, Archived

        [Display(Name = "Owner")]
        public string OwnerUserId { get; set; }        // Foreign Key - Owner of Ticket (the Submitter who entered the ticket into the system?  Or the Project Manager it would be under?)

        [Display(Name = "Assigned To")]
        public string AssignedToUserId { get; set; }  // Foreign Key - User that the Ticket is assigned to - what if this is null?

        // rest of db properties
        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Title")]
        public string Title { get; set; }              // Title of the ticket

        [Display(Name = "Description")]
        public string Description { get; set; }        // Description of the ticket

        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "% Complete")]
        public int PercentComplete { get; set; }       // Percent Complete

        [Display(Name = "Created")]
        public DateTimeOffset Created { get; set; }    // When the ticket was added into the system

        [Display(Name = "Updated")]
        public DateTimeOffset? Updated { get; set; }   // Last time the ticket was updated in the system

        [Display(Name = "Archived")]
        public bool Archived { get; set; }
    }
}

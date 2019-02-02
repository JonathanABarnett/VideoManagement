using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using VideoManagement.Models;

namespace VideoManagement.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        [Required(ErrorMessage = "Please select a membership type.")]
        public int MembershipTypeId { get; set; }
    }
}
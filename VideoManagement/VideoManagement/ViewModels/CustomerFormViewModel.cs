using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoManagement.Models;

namespace VideoManagement.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }       
    }
}
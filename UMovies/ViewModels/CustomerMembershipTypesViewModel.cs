using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMovies.Models;

namespace UMovies.ViewModels
{
    public class CustomerMembershipTypesViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UMovies.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

       
        [Required(ErrorMessage ="Enter a name")]
        [StringLength(255)]
        public string Name { get; set; }
         
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

    }
}
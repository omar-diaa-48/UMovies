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
        [Display(Name ="Customer Name")]
        public string Name { get; set; }


        [DataType(DataType.Date)]
        [Display(Name="Birth Date")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name="Membership")]
        public int MembershipTypeID { get; set; }

        public MembershipType MembershipType { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using VidlyNew.Models;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //Data Annotations
        
        [Required(ErrorMessage ="Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscriedNewsLetter { get; set; }

        public MemberShipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdata { get; set; }
    }
}
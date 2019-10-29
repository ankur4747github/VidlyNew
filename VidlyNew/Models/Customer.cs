using System;
using System.ComponentModel.DataAnnotations;
using VidlyNew.Models;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //Data Annotations
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscriedNewsLetter { get; set; }
        public MemberShipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthdata { get; set; }
    }
}
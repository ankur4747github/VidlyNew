using System;
using System.ComponentModel.DataAnnotations;
using VidlyNew.Models;

namespace VidlyNew.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        //Data Annotations

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscriedNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MemberShipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember] for IHttpActionResultInApi
        public DateTime? Birthdata { get; set; }
    }
}
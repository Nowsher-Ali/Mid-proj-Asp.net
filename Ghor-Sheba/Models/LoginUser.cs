//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ghor_Sheba.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class LoginUser
    {
        public LoginUser()
        {
            this.Booking_confirms = new HashSet<Booking_confirms>();
            this.Bookings = new HashSet<Booking>();
            this.Reviews = new HashSet<Review>();
            this.service_provider_status = new HashSet<service_provider_status>();
        }
    
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
        public string user_type { get; set; }
        [Required]
        public string address { get; set; }
        public string status { get; set; }
        [Required]
        public string fullname { get; set; }
    
        public virtual ICollection<Booking_confirms> Booking_confirms { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<service_provider_status> service_provider_status { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using LEGO.CORE;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LEGO.ENTITY
{
    [Table("CoreUser")]
    public class CoreUser : BaseClass
    {
        [Required]
        [MaxLength(50)]
        [DisplayName("Email:")]
        public string CoreEmail { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("UserName:")]
        public string CoreUserName { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Password:")]
        public string CorePassword { get; set; }
        public DateTime Date { get; set; }

        public int IsActivate { get; set; }    // Activate: 1 & Deactivate: 0       
    }
}

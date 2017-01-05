using System;
using System.ComponentModel.DataAnnotations.Schema;
using LEGO.CORE;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LEGO.ENTITY
{
    [Table("CoreMember")]
    public class CoreMember : BaseClass
    {
        [Required]
        [MaxLength(30)]
        [DisplayName("Full Name:")]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int IsActivate { get; set; }
        public CoreUser UserId { get; set; }
        
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using LEGO.CORE;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace LEGO.ENTITY
{
    public class Clients : BaseClass
    {
      
        public string ClientName { get; set; }
        public string ReportDescription { get; set; }
        public string Type { get; set; }
        public int? Parent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project_REMS.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int NoOfRooms { get; set; }
        public decimal Price { get; set; }
    }
}
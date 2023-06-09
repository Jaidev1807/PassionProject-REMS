using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Project_REMS.Models
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string ConatactInfo { get; set; }
        public string Sepcialization { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal PerfomanceMetrics { get; set; }

    }
}
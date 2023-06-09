using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Project_REMS.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int PropertyId { get; set; }
        public int AgentId { get; set; }
        public string BuyerInfo { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
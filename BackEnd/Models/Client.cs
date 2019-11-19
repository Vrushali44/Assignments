using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SearchName.Models
{
    public class Client
    {
        [Key]
        public int clientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<ClientAdd> clientAdd { get; set; }
    }
}
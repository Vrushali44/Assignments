using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SearchName.Models
{
    public class ClientAdd
    {
        [Key]
        public int a_Id { get; set; }
        public string address { get; set; }

        public int clientId { get; set; }
        public Client client { get; set; }
    }
}
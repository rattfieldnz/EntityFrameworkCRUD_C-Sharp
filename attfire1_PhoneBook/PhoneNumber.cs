using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace attfire1_PhoneBook
{
    class PhoneNumber
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string Number { get; set; }
        public Contact Contact { get; set; }
    }
}

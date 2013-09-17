using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace attfire1_PhoneBook
{
    class Contact
    {
        public Contact()
        {
            PhoneNumbers = new List<PhoneNumber>();
        }
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Required]
        public virtual List<PhoneNumber> PhoneNumbers { get; set; }

        public override string ToString()
        {
            return Id + " " + FirstName + " " + Surname + " " + PhoneNumbers[0].Number;
        }
    }
}

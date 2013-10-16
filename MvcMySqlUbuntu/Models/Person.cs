using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMySqlUbuntu.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [DisplayName("Last Name")]
        [Required]     
        public string LastName { get; set; }
        [DisplayName("First Name")]
        [Required]   
        public string FirstName { get; set; }
        [DisplayName("Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        public virtual List<Phone> Phones { get; set; }
    }

    public class Phone
    {
        public int PhoneId { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
    }
}
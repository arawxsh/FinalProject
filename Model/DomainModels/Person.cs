﻿using System.ComponentModel.DataAnnotations;

namespace Model.DomainModels
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalId { get; set; }
    }
}

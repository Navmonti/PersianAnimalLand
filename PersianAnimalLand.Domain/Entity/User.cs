﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersianAnimalLand.Domain.Entity
{
    [Table("User")]
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Firstname { get; set; }


        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

    }
}

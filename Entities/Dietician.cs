﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DieticianApp.Entities
{
    [Index(nameof(Dietician_Name), IsUnique = true)]
    [Index(nameof(Dietician_Email), IsUnique = true)]

    public class Dietician
    {
        [Key]
        public int Dietician_Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Dietician_Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email format is not correct")]
        public string? Dietician_Email{ get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6)]
        public string? Password { get; set; }

        public string? AvatarUrL { get; set; }

        [StringLength(255, MinimumLength = 2)]
        public string? Description{ get; set; }
        public string? Mobile {  get; set; }
        public string? Role { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime? Updated_At { get; set; }

        // Relation
    }
}
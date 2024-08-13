﻿using System.ComponentModel.DataAnnotations;

namespace DieticianApp.Entities
{
    public class Menu
    {
        [Key]
        public int Menu_Id{ get; set; }

        [Required(ErrorMessage = "Menu name is required")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Minimum length is 3 character")]
        public string? Menu_Name{ get; set; }
        public string? Comment{ get; set; }
        public string? Created_by { get; set; }
        public DateTime Menu_Start{ get; set; }
        public DateTime Menu_End{ get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime? Updated_At { get; set; }

        // Relation
        
    }
}
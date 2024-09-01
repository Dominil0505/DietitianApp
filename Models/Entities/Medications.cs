﻿using DieticianApp.Models.JoinTables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DieticianApp.Models.Entities
{
    [Index(nameof(Medicine_Name), IsUnique = true)]

    public class Medications
    {
        [Key]
        public int Medicine_Id { get; set; }
        public string? Medicine_Name { get; set; }

        // Relation
        public virtual ICollection<Patient_Medication> PatientMedications { get; set; } = new List<Patient_Medication>();
    }
}

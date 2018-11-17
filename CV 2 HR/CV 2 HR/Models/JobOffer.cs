﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV_2_HR.Models
{
    public class JobOffer
    {
        public int Id { get; set; }

        [Display(Name = "Job title")]
        [Required]
        public string JobTitle { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        [Display(Name = "Salary from")]
        public decimal? SalaryFrom { get; set; }

        [Display(Name = "Salary to")]
        public decimal? SalaryTo { get; set; }

        public DateTime Created { get; set; }
        public string Location { get; set; }

        [Required][MinLength(100)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyy-MM-dd}")]
        [Display(Name = "Valid until")]
        public DateTime? ValidUntil { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV_2_HR.Models
{
    public class JobApplication: IValidatableObject
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Phone]
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Contact agreement")]
        public bool ContactAgreement { get; set; }
        [Url]
        [Required]
        [Display(Name = "CV url")]
        public string CvUrl { get; set; }
        
        public virtual JobOffer Offer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!ContactAgreement)
            {
                yield return new ValidationResult("You must check this box to proceed.", new[] { "ContactAgreement" });
            }
        }
    }
}

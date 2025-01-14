﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RamirezforaneoApp.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the event")]
        [StringLength(100, ErrorMessage = "Event title cannot exceed 100 characters")]
        [Display(Name = "Event Title")]
        public string EventTitle { get; set; }

        [Required(ErrorMessage = "Please enter the description of the event")]
        [StringLength(600, ErrorMessage = "Event description cannot exceed 600 characters")]
        [Display(Name = "Event Description")]
        public string EventDescription { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryRefId { get; set; }
        public Category EventCategory { get; set; }

        [Required(ErrorMessage = "Please enter the location of the event")]
        [Display(Name = "Location")]
        public string EventLocation { get; set; }

        [DataType(dataType: DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Please enter the start date of the event")]
        public DateTime EventStartDate { get; set; }

        [DataType(dataType: DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please enter the end date of the event")]
        public DateTime EventEndDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Creation Date")]
        public DateTime EventCreationDate { get; set; } = DateTime.Now;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCOdysseyTwo.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage ="Move Title is required, idiot.")]
        [MaxLength(100, ErrorMessage ="No movie has a Title that long; try again.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Release year is required.  Don't you know anything?")]
        [Range(1900, 2020, ErrorMessage ="That year doesn't seem right to me.  Try again.")]
        public int Year { get; set; }


    }
}
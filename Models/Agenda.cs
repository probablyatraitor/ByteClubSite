﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByteClubSite.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        public string Class { get; set; }
        public string Body { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        public TimeSpan StartLate { get; set; }
        [Required]
        public TimeSpan StartEarlyDismiss { get; set; }
        [Required]
        public TimeSpan StartActivity { get; set; }
        [Required]
        public bool Active { get; set; }
        //Maybe have templated rows where user just types in assignment name and details
        //Have "No class" checkbox; generate empty instance
    }
}

using Microsoft.EntityFrameworkCore;
using MyInstagram.Data;
using MyInstagram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyInstagram.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public enum State { Unpublished, Published, Deleted }

        [Required]
        public DateTime DateUploaded { get; set; }

        [Required]
        [StringLength(255)]
        public string Filename { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int CurrentState { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1To4.Models
{
    public class Course
    {

        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Resources = new HashSet<Resource>();
            this.Submissions = new HashSet<Homework>();
    }
        [Key]
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        
        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Homework> Submissions { get; set; }
    }
}

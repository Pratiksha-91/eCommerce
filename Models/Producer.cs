﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace final_demo_mvc.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }


       

        public List<Movie> movies { get; set; }

    }
}

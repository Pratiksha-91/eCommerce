﻿using final_demo_mvc.Models;

namespace eCommerce.Models
{
    public class Actor_Movie
    {

        public int MovieId { get; set; }
        public Movie Movie { get; set; }    

        public int ActorId { get; set; }

        public int Actor { get; set; }

    }
}
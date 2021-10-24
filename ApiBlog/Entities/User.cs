﻿using System;
using System.Collections.Generic;

namespace ApiBlog.Repository.Entities
{
    public class User
    {
        public int UserId { get; set; }
        
        public string Names { get; set; }

        public string Surnames { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Created { get; set; }

        public string Role { get; set; }

        public int StatusUser { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

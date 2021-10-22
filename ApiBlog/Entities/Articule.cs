﻿using System;
using System.Collections.Generic;

namespace ApiBlog.Repository.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string Keyword { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}

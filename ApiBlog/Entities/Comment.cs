using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        //foreignKey
        public User User { get; set; }

        //foreignKey
        public Articule Articule { get; set; }
    }
}

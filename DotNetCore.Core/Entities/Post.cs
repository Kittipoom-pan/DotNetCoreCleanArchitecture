using System;
using System.Collections.Generic;

namespace DotNetCore.Core.Entities
{
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UsersId { get; set; }

        public virtual User Users { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}

using System;

namespace DotNetCore.Core.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public int? UsersId { get; set; }
        public string Description { get; set; }
        public DateTime? CreateAt { get; set; }
        public bool? IsActive { get; set; }

        public virtual Post Post { get; set; }
        public virtual User Users { get; set; }
    }
}

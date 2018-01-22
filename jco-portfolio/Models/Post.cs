using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("Posts")]
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

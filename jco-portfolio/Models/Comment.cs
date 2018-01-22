using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PostId { get; set; }
        public virtual Post post { get; set; }
    }
}

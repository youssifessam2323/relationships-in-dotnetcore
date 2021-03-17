using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships_in_efcore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [Column("comment_text")]
        public string CommentText { get; set; }
        
        public List<Comment> Replies { get; set; }
        
        
    }
}
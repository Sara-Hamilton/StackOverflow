using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public string Content { get; set; }
        public int VoteTally { get; set; } = 0;
        public bool Best { get; set; } = false;

        public virtual ApplicationUser User { get; set; }
    }
}

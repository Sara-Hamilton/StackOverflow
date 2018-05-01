using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    [Table("Users_Answers")]
    public class Users_Answers
    {
        [Key]
        public int UAKey { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        [ForeignKey("AnswerId")]
        public string AnswerId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}

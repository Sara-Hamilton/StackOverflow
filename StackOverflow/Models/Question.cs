﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [ForeignKey ("UserId")]
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int VoteTally { get; set; } = 0;

        public virtual ApplicationUser User { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}

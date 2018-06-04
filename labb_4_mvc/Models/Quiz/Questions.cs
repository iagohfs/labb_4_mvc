using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace labb_4_mvc.Models.Quiz
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }

        public string Question { get; set; }

        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }

        public AnswerChoices CorrectAnswer { get; set; }

    }
}

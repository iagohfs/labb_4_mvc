﻿using System;
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

        public AnswerChoices CorrectAnswer { get; set; }

    }
}

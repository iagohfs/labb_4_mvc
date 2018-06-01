using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace labb_4_mvc.Models.Quiz
{
    public class UserScore
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Questions Question { get; set; }

        public int Points { get; set; }
    }
}

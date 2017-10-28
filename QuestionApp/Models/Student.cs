using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string email { get; set; }
        public string Paswoord { get; set; }

        public ICollection<Vraag> Vragen { get; set; }

    }
}

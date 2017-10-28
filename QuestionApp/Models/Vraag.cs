using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionApp.Models
{
    public class Vraag
    {
        public int VraagID { get; set; }
        public string Titel { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public int Score { get; set; }
        public bool Markeren { get; set; }

        public Student Studenten { get; set; }
        public Leerkracht Leerkrachten { get; set; }
    }
}

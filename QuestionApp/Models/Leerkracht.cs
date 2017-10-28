using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionApp.Models
{
    public class Leerkracht
    {
        public int LeerkrachtID { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Paswoord { get; set; }

        public ICollection<Vraag> Vragen{ get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestionApp.Data;

namespace QuestionApp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(VraagContext context)
        {
            context.Database.EnsureCreated();

            // Look for any countries.
            if (context.Leerkachten.Any())
            {
                return;   // DB has been seeded
            }
            context.Leerkachten.AddRange(
                new Leerkracht { Naam = "Peeters", Voornaam = "Tom" },
                new Leerkracht { Naam = "Marien", Voornaam = "Sven"}
                );
            context.SaveChanges();

            context.Studenten.AddRange(
                new Student { Naam = "Tauil", Voornaam = "Nabil"},
                new Student { Naam = "Creve", Voornaam = "Koen"},
                new Student { Naam="Meysman", Voornaam="Scott"}

                );
            context.SaveChanges();

            context.Vragen.AddRange(
                new Vraag
                {
                    Titel = "Wat is een database",
                    Tekst = "",
                    Score = 5,
                    Datum = DateTime.Parse("2017-12-12"),
                    Markeren = false,
                },
                new Vraag
                {
                    Titel = "Waarom is 42 het antwoord op alles",
                    Tekst = "Hitchikers Guide To The Galaxy",
                    Score = 42,
                    Datum = DateTime.Parse("2017-06-12"),
                    Markeren = true,
                },
                new Vraag
                {
                    Titel = "Geen vraag enkel test",
                    Tekst = "Groot",
                    Score = -5,
                    Datum = DateTime.Parse("055-06-26"),
                    Markeren = false,
                }
                );
            context.SaveChanges();
        }
    }
}

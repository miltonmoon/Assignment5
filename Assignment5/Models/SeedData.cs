using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            Assignment5DBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<Assignment5DBContext>();
            
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Textbooks.Any())
            {
                context.Textbooks.AddRange(

                    new Textbook
                    {
                        Title = "Les Miserables",
                        AuthFirst = "Victor",
                        AuthLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Cat = "Fiction, Classic",
                        Price = 9.95,
                        Pages = 1488,
                    },

                    new Textbook
                    {
                        Title = "Team of Rivals",
                        AuthFirst = "Doris",
                        AuthLast = "Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Cat = "Non-Fiction, Biography",
                        Price = 14.58,
                        Pages = 944,
                    },

                    new Textbook
                    {
                        Title = "The Snowball",
                        AuthFirst = "Alice",
                        AuthLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Cat = "Non-Fiction, Biography",
                        Price = 21.54,
                        Pages = 832,
                    },

                    new Textbook
                    {
                        Title = "American Ulysses",
                        AuthFirst = "Ronald C.",
                        AuthLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Cat = "Non-Fiction, Biography",
                        Price = 11.61,
                        Pages = 864,
                    },

                    new Textbook
                    {
                        Title = "Unbroken",
                        AuthFirst = "Laura",
                        AuthLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Cat = "Non-Fiction, Historical",
                        Price = 13.33,
                        Pages = 528,
                    },

                    new Textbook
                    {
                        Title = "The Great Train Robbery",
                        AuthFirst = "Michael",
                        AuthLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Cat = "Fiction, Historical Fiction ",
                        Price = 15.95,
                        Pages = 288,
                    },

                    new Textbook
                    {
                        Title = "Deep Work",
                        AuthFirst = "Cal",
                        AuthLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Cat = "Non-Fiction, Self-Help",
                        Price = 14.99,
                        Pages = 304,
                    },

                    new Textbook
                    {
                        Title = "It's Your Ship",
                        AuthFirst = "Michael",
                        AuthLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Cat = "Non-Fiction, Self-Help",
                        Price = 21.66,
                        Pages = 240,
                    },

                    new Textbook
                    {
                        Title = "The Virgin Way",
                        AuthFirst = "Richard",
                        AuthLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Cat = "Non-Fiction, Business",
                        Price = 29.16,
                        Pages = 400,
                    },

                    new Textbook
                    {
                        Title = "Sycamore Row",
                        AuthFirst = "John",
                        AuthLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Cat = "Fiction, Thrillers",
                        Price = 15.03,
                        Pages =642,
                    },

                    new Textbook
                    {
                        Title = "Way of Kings",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Cat = "Fiction, Fantasy",
                        Price = 9.59,
                        Pages = 1007,
                    },

                    new Textbook
                    {
                        Title = "Oathbringer",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326379",
                        Cat = "Fiction, Fantasy",
                        Price = 18.49,
                        Pages = 1248,
                    },

                    new Textbook
                    {
                        Title = "Rythm of War",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326386",
                        Cat = "Fiction, Fantasy",
                        Price = 18.89,
                        Pages = 1232,
                    }

                );

                context.SaveChanges();
            }
        }
    }
}

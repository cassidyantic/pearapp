using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Calculus 101",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Introductory to calculus concepts",
                        Category = "math",
                        City = "Annapolis",
                        Venue = "Broadneck Library",
                    },
                    new Activity
                    {
                        Title = "Literature Review",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Literature review group for English 102",
                        Category = "language arts",
                        City = "Baltimore",
                        Venue = "Baltimore Library",
                    },
                    new Activity
                    {
                        Title = "Algorithims",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Intro to Algorithims review group",
                        Category = "math",
                        City = "Dover",
                        Venue = "Eli Harting's house",
                    },
                    new Activity
                    {
                        Title = "Data Structures",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Review for data structures final",
                        Category = "computer science",
                        City = "Towson",
                        Venue = "Park",
                    },
                    new Activity
                    {
                        Title = "Psychology 101",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Activity 3 months in future",
                        Category = "psychology",
                        City = "Annapolis",
                        Venue = "Local Library",
                    },
                    new Activity
                    {
                        Title = "Introductory Math",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Preparation for Introductory Math Exam",
                        Category = "math",
                        City = "Washington, DC",
                        Venue = "Amanda Smith's house",
                    },
                    new Activity
                    {
                        Title = "Underwater Basket Weaving",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Basket weaving demonstration",
                        Category = "hobby",
                        City = "Crofton",
                        Venue = "Brittany Hall's house",
                    },
                    new Activity
                    {
                        Title = "Spanish",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Spanish exam review",
                        Category = "language arts",
                        City = "Bel Air",
                        Venue = "Baltimore Library",
                    },
                    new Activity
                    {
                        Title = "Turkish Stepdancing",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Turskish stepdancing demonstration",
                        Category = "hobby",
                        City = "Gambrills",
                        Venue = "Towson Library",
                    },
                    new Activity
                    {
                        Title = "Flute Playing",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Learn to play the flute",
                        Category = "music",
                        City = "Gambrills",
                        Venue = "Park",
                    }
                
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}
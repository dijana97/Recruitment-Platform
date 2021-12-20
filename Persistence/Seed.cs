using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Skills.Any()) return;
            
            var skills = new List<Skill>
            {
                new Skill
                {
                    Name = "Java programming",
                },
                new Skill
                {
                    Name = "C# programming",
                },
                new Skill
                {
                    Name = "Database design",
                },
                new Skill
                {
                    Name = "English language",
                },
                new Skill
                {
                    Name = "Russian language",
                },
                new Skill
                {
                    Name = "German language",
                }
            };

            await context.Skills.AddRangeAsync(skills);
            await context.SaveChangesAsync();
        }
    }
}
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestForLsiSoftware.Models;

namespace TestForLsiSoftware.EF
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Raports.Any())
            {
                context.Raports.AddRange(
                    new Raport
                    {
                        Name = "Test1",
                        DateTimeOfCreate = new DateTime(2020, 3, 17, 10, 00, 00),
                        Creator = "User1",
                        Local = "Local1"
                    },
                    new Raport
                    {
                        Name = "Test2",
                        DateTimeOfCreate = new DateTime(2020, 6, 17, 10, 00, 00),
                        Creator = "User2",
                        Local = "Local2"
                    },
                    new Raport
                    {
                        Name = "Test3",
                        DateTimeOfCreate = new DateTime(2020, 9, 17, 10, 00, 00),
                        Creator = "User3",
                        Local = "Local3"
                    });

                context.SaveChanges();
            }
        }
    }
}
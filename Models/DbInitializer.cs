using System;
using System.Collections.Generic;
using System.Linq;

namespace PieShopEmpty.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(
                    new Pie { Name = "Apple Pie", Price = 12.95M, ShortDescription = "Description", LongDescription = "LooongDescription", ImageThumbnailUrl = "https://i.pinimg.com/originals/6c/48/c2/6c48c2f0f8d8579a4751f534f4fa4ca0.jpg", IsPieOfTheWeek = true },
                    new Pie { Name = "Banana Pie", Price = 9.90M, ShortDescription = "It's the better", LongDescription = "Descriiiiiippptioooon", ImageThumbnailUrl = "https://img.buzzfeed.com/video-api-prod/assets/f78b2d95fc904dfb908e21862da36534/YT_THUMB.jpg" },
                    new Pie { Name = "Lemon Pie", Price = 15.90M, ShortDescription = "Desc.", LongDescription = "Descriiiiiippptioooon", ImageThumbnailUrl = "https://images-gmi-pmc.edge-generalmills.com/a910e898-ce3a-4d64-a6e0-a6580559d6ae.jpg" }
                );

                context.SaveChanges();
            }
        }
    }
}

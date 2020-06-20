using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data
{
    public class DataItem
    {
        private static string heading = "" +
            " Coronavirus is a type of common virus that infects humans, typically leading to an upper respiratory infection (URI.)  Seven different types of human coronavirus have been identified. Most people will be infected with at least one type of coronavirus in their lifetime. The viruses are spread through the air by coughing and sneezing, close personal contact, touching an object or surface contaminated with the virus and rarely, by fecal contamination. The illness caused by most coronaviruses usually lasts a short time and is characterized by runny nose, sore throat, feeling unwell, cough, and fever. ";
        private static string imageHome = "http://adx.azureedge.net/Images/Watermark";
        public string Title { get; set; }
        public string Summary { get; set; } = heading;
        public string Author { get; set; } = "";
        public DateTime Timestamp { get; set; }
        public int Likes { get; set; }
        public string HeroImage { get; set; }
        public bool IsHero { get; set; } = false;

        public static List<DataItem> GetData()
        {
            var items = new List<DataItem>();
            items.Add(new DataItem()
            {
                Title = "COVID - 19",
                Timestamp = DateTime.Now,
                Likes = 2,
                HeroImage = $"{imageHome}/logo.jpg",
                IsHero = true
            });
           
            /*
            items.Add(new DataItem()
            {
                Title = "TAKING IT BACK",
                Timestamp = DateTime.Now,
                Likes = 5,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image60.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "ALL FOR THE GAME",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 4,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image13.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "FUTURE OF TOMORROW",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 7,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image41.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "THE VOICE OF TOMORROW",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 3,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image11.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "TAKING IT ALL ON",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 4,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image12.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "BEYOND THE OLYMPICS",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 7,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image30.jpg"
            });
            items.Add(new DataItem()
            {
                Title = "A ROAD LESS TRAVELED",
                Timestamp = items.Last().Timestamp - TimeSpan.FromMinutes(new Random().Next(9, 36) * 10),
                Likes = 3,
                HeroImage = $"{imageHome}/Large/FeaturedImage_2x1_Image23.jpg"
            });

    */
            return items;
        }

        public static List<string> GetListOfTopics()
        {
            var topics = new List<string>();
            topics.Add("CORONA");
            topics.Add("SYMPTOMS");
            topics.Add("PRECAUTIONS");
            topics.Add("MEALS");
            topics.Add("SELF TEST");
           

            return topics;
        }
    }
}

using AlgorithmicsAPI.Data.Models;

namespace AlgorithmicsAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context != null && !context.Algorithms.Any())
                {
                    context.Algorithms.AddRange(
                        new Algorithm()
                        {
                            Name = "Bubble sort",
                            Description = "This is a sorting algorithm",
                            AlgorithmNickName = "bubble",
                            Type = (AlgorithmType)Enums.AlgorithmType.Sorting,
                            CreationDate = DateTime.Now,
                            Url = "https://www.youtube.com/watch?v=lyZQPjUT5B4"
                        },
                        new Algorithm()
                        {
                            Name = "Insertion sort",
                            Description = "This is a sorting algorithm",
                            AlgorithmNickName = "insertion",
                            Type = (AlgorithmType)Enums.AlgorithmType.Sorting,
                            CreationDate = DateTime.Now,
                            Url = "https://www.youtube.com/watch?v=ROalU379l3U&t=8s"
                        },
                        new Algorithm()
                        {
                            Name = "Selection sort",
                            Description = "This is a sorting algorithm",
                            AlgorithmNickName = "selection",
                            Type = (AlgorithmType)Enums.AlgorithmType.Sorting,
                            CreationDate = DateTime.Now,
                            Url = "https://www.youtube.com/watch?v=Ns4TPTC8whw&t=6s"
                        },
                        new Algorithm()
                        {
                            Name = "Merge sort",
                            Description = "This is a sorting algorithm",
                            AlgorithmNickName = "merge",
                            Type = (AlgorithmType)Enums.AlgorithmType.Sorting,
                            CreationDate = DateTime.Now,
                            Url = "https://www.youtube.com/watch?v=XaqR3G_NVoo"
                        },
                        new Algorithm()
                        {
                            Name = "Binary search",
                            Description = "This is a searching algorithm",
                            AlgorithmNickName = "binary",
                            Type = (AlgorithmType)Enums.AlgorithmType.Searching,
                            CreationDate = DateTime.Now,
                            Url = "https://www.youtube.com/watch?v=iP897Z5Nerk"
                        }
                        );
                }
            }
        }
    }
}

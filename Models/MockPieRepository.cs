using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopEmpty.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Short Description", IsPieOfTheWeek = false, LongDescription = "Loooooong Description", ImageThumbnailUrl="https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/ddb375f6-cc66-4f94-ac8f-702cd187df65-600.jpg" },
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Short Description", IsPieOfTheWeek = false, LongDescription = "Loooooong Description", ImageThumbnailUrl="https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/ddb375f6-cc66-4f94-ac8f-702cd187df65-600.jpg" },
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Short Description", IsPieOfTheWeek = false, LongDescription = "Loooooong Description", ImageThumbnailUrl="https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/ddb375f6-cc66-4f94-ac8f-702cd187df65-600.jpg" },
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Short Description", IsPieOfTheWeek = false, LongDescription = "Loooooong Description", ImageThumbnailUrl="https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/ddb375f6-cc66-4f94-ac8f-702cd187df65-600.jpg" }
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie getPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }   
    }
}

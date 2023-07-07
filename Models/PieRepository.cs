using Microsoft.EntityFrameworkCore;

namespace MyPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        public readonly MyPieShopDbContext _myPieShopDbContext;

        public PieRepository(MyPieShopDbContext myPieShopDbContext)
        {
            _myPieShopDbContext = myPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _myPieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _myPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int id)
        {
            return _myPieShopDbContext.Pies.FirstOrDefault(p=>p.PieId == id);
        }
    }
}

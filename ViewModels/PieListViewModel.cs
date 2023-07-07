using MyPieShop.Models;

namespace MyPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get;}
        public string DummyData { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string dummyData)
        {
            Pies = pies;
            DummyData = dummyData;
        }
    }
}

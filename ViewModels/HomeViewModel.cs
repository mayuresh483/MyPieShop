using MyPieShop.Models;

namespace MyPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> piesOfTheWeek { get; }

       public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            this.piesOfTheWeek = piesOfTheWeek;
        }
    }
}

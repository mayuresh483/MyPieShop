namespace MyPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int id);
    }
}

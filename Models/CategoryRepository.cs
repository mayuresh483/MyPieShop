namespace MyPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly MyPieShopDbContext _myPieShopDbContext;

        public CategoryRepository(MyPieShopDbContext myPieShopDbContext)
        {
            _myPieShopDbContext = myPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _myPieShopDbContext.Categories.OrderBy(c => c.CategoryName);
            }
        }
    }
}

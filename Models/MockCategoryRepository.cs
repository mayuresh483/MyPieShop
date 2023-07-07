namespace MyPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1 , CategoryName = "Fruit", Description="Fruits are healthy for Body"},
                new Category{CategoryId=2 , CategoryName = "Fruit2", Description="Fruits are healthy for Body2"},
                new Category{CategoryId=3 , CategoryName = "Fruit3", Description="Fruits are healthy for Body3"},
                new Category{CategoryId=4 , CategoryName = "Fruit4", Description="Fruits are healthy for Body4"},
            };
    }
}

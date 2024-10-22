namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>()
            {
                new Pie{PieId = 1, Name = "Strawberry pie", Price = 15, ShortDescription = "Tasty", Category = _categoryRepository.AllCategories.First(x => x.CategoryName == "Fruit pies"), ImageThumnailUrl = "~/Images/16.jpg"},
                new Pie{PieId = 1, Name = "Cheese cake", Price = 18, ShortDescription = "Tasty", Category = _categoryRepository.AllCategories.First(x => x.CategoryName == "Cheese pies"), ImageThumnailUrl = "~/Images/21.jpg"},
                new Pie{PieId = 1, Name = "Rhubarb pie", Price = 15, ShortDescription = "Tasty", Category = _categoryRepository.AllCategories.First(x => x.CategoryName == "Fruit pies"), ImageThumnailUrl = "~/Images/7.jpg"},
                new Pie{PieId = 1, Name = "Pumpkin pie", Price = 12, ShortDescription = "Tasty", Category = _categoryRepository.AllCategories.First(x => x.CategoryName == "Seasonal pies"), ImageThumnailUrl = "~/Images/16.jpg"}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie? GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(x => x.PieId == pieId);
        }
    }
}

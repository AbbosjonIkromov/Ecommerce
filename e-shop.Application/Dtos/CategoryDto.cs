namespace e_shop.Application.Dtos
{
    public class CategoryDto
    {
        public int  Id { get; set; }
        public string  CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Icon { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }

    }
}

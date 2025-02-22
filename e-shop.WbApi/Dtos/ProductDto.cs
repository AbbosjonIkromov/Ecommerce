using System.Security.Principal;

namespace e_shop.WbApi.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public string SKU { get; set; }
        public string ProductNote { get; set; }
        public decimal ProductWeight { get; set; }
        public bool Published  { get; set; }
    }
}

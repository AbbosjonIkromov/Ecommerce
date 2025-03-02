using System.Security.Principal;

namespace e_shop.Application.Dtos
{
    public class CreateProductRequesDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public string? SKU { get; set; }
        public string ProductNote { get; set; }
        public decimal ProductWeight { get; set; }
        public bool Published { get; set; } = false;
    }
}

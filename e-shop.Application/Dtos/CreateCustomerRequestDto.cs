namespace e_shop.Application.Dtos
{
    public class CreateCustomerRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}

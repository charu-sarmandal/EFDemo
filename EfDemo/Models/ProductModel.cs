namespace EfDemo.Models
{
    public class ProductModel
    {

        public int Id { get; set; }

        public string  PrdName{ get; set; }

        public string PrdType { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Model.DomainModels
{
    public class Product
    {
        [Key]
        public int Code { get; set; }
        public string Title { get; set; }
        public int UnitPrice { get; set; }
    }
}

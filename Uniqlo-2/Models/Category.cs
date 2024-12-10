using Uniqlo_2.Models.Base;

namespace Uniqlo_2.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

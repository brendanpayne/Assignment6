using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDatabase.Entities
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        public float UnitPrice { get; set; }
        public string? QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }

        public static implicit operator Product(List<Product> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }
}

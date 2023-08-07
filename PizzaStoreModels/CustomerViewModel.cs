using StoreDatabase.Entities;
using System.ComponentModel;

namespace PizzaStoreModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [DisplayName("Full Name")]
        public string? FullName => $"{LastName}, {FirstName}";
        public string? Email { get; set; }
        [DisplayName("Phone Number")]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        [DisplayName("State/Province")]
        public string? Region { get; set; }
        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
    }
}

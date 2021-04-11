using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerCreditCard : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public int CardId { get; set; }
    }
}
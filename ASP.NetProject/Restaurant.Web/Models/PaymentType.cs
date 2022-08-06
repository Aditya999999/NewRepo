using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Web.Models
{
    [Table(name: "Payments")]
    public class PaymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int PaymentTypeId { get; set; }

        [Required]
        [StringLength(50)]
        virtual public string PaymentTypeName { get; set; }

        #region Navigation to the order details
        
        public ICollection<OrderDetail> OrderDetails { get; set; }

        #endregion

        #region Navigation Properties to the Customer Model 
        virtual public int CustomerId { get; set; }

        [ForeignKey(nameof(PaymentType.CustomerId))]

        public Customer Customer { get; set; }


        #endregion
    }
}

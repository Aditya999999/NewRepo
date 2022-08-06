using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Web.Models
{
    [Table(name: "OrderDetails")]
    public class OrderDetail
    {
        virtual public int OrderDetailId { get; set; }
       
        virtual public int ItemId { get; set; }
        virtual public decimal UnitPrice { get; set; }
        virtual public decimal Discount { get; set; }
        virtual public decimal Total { get; set; }
        virtual public decimal Quantity { get; set; }

        virtual public string CreatedBy { get; set; }

        virtual public DateTime CreatedDate { get; set; }

        virtual public string UpdatedBy { get; set; }

        virtual public DateTime UpdatedDate { get; set; }

        [Required]
        virtual public int OrderId { get; set; }
        [ForeignKey(nameof(OrderDetail.OrderId))]
        
        public virtual Order Order { get; set; }


        [NotMapped]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

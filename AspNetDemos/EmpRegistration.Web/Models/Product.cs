using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpRegistration.Web.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Discontinued { get; set; }

        #region Navigation Properties to the Category Model

        public int ProductCategoryId { get; set; }

        [ForeignKey(nameof(Product.ProductCategoryId))]

        public ProductCategory ProductCategory { get; set; }

        #endregion
    }
}

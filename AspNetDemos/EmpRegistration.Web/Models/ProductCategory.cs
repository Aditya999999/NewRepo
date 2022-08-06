using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmpRegistration.Web.Models
{
    [Table(name: "ProductCategories")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryId { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        [StringLength(100)]
        public string ProductCategoryName { get; set; }

        #region Navigation Properties
        public ICollection<Product> Products { get; set; }

        #endregion


    }
}

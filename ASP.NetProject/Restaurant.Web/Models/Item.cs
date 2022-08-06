using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Web.Models
{
    [Table(name: "Items")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int ItemId { get; set; }

        [Required]
        [StringLength(150)]
        virtual public string ItemName { get; set; }

        [Required]
        [StringLength(20)]
        virtual public string ItemType { get; set; }

        [StringLength(350)]
        virtual public string ItemDescription { get; set; }

        [Required]
        [DefaultValue(true)]
        virtual public bool IsAvailable { get; set; }

        [Required]
        virtual public decimal? Price { get; set; }

        virtual public string CreatedBy { get; set; }

        virtual public DateTime CreatedDate { get; set; }

        virtual public string UpdatedBy { get; set; }

        virtual public DateTime UpdatedDate { get; set; }

        #region Navigation Properties to the order model

        virtual public int ItemCategoryId { get; set; }

        [ForeignKey(nameof(Item.ItemCategoryId))]

        public ItemCategory ItemCategory { get; set; }

        #endregion


    }
}

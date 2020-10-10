using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PuraniKitab.Models
{
     public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Category")]
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

         [Required]
        public DateTime CreateDate { get; set; }

        [MaxLength(50)]
         public string CreatedBy { get; set; }

        public Boolean IsActive { get; set; }

         public int TotalCount { get; set; }


    }
}

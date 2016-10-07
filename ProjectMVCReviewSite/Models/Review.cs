using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectMVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Product")]
        public string Name { get; set; }
        [Display(Name = "Published Date")]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Review")]
        public string Content { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
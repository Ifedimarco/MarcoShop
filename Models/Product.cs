using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarcoShorp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductsName { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductsModel { get; set; }
        [Required]
        public int ProductsPrice { get; set; }
        [StringLength(150)]
        public string ProductsImage { get; set; }
        [NotMapped]
        [Display(Name ="UploadFile")]
        public IFormFile ImageFile { get; set; }
        public Product()
        {

        }
    }
}

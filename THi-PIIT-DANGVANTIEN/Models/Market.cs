using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace THi_PIIT_DANGVANTIEN.Models
{
    public class Market
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên BitCoin")]
        [Required(ErrorMessage = "Yêu cầu nhập tên BitCoin")]
        public string Name { get; set; }
        [Display(Name = "description")]
        [Required(ErrorMessage = "Yêu cầu nhập Mô tả")]
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAd { get; set; }
        public int status { get; set; }
     

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THi_PIIT_DANGVANTIEN.Models
{
    public class BitCoin
    {
        [Key]
        public int Id { get; set; }

        

        [Display(Name = "Tên BitCoin")]
        [Required(ErrorMessage = "Yêu cầu nhập tên BitCoin")]
        public string Name { get; set; }

        [Display(Name = "baseAsset")]
        [Required(ErrorMessage = "Yêu cầu nhập tên BaseAsset")]
        public string baseAsset { get; set; }

        [Display(Name = "quoteAsset")]
        [Required(ErrorMessage = "Yêu cầu nhập quoteAsset")]
        public string quoteAsset { get; set; }
        [Display(Name = "lastPrice")]
        [Required(ErrorMessage = "Yêu cầu nhập tên LashPrice")]
        public double lastPrice { get; set; }
        [Display(Name = "volumn24h")]
        [Required(ErrorMessage = "Yêu cầu nhập tên volumn24h")]
        public double volumn24h { get; set; }

       
        public int marketId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int status { get; set; }
        public virtual Market Market { get; set; }

    }
}
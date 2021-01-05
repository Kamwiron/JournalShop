using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JournalShop.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public string Material { get; set; }

        [Display(Name = "Stock Date")]
        [DataType(DataType.Date)]
        public DateTime StockDate { get; set; }
        public string Size { get; set; }
        public int PageNumber { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductExplanation { get; set; }//açıklama
        
        public bool? ProductUseCase { get; set; }
        public string? ProductImg { get; set; }
        public int ProductPrice { get; set; }
        public bool ProductIsOfferable { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Offer> Offers{ get; set; }

        public int UserId { get; set; }
        public User User { get; set; }








    }
}

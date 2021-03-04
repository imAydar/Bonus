using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bonus.Data.Models
{
    public class Store
    {
        public int Id { get; set; }
        
        [Display(Name = "код магазина в 1с")]
        public int Code { get; set; }
        
        [Display(Name = "Название")]
        [MaxLength(50, ErrorMessage = "Превышена максимальная длина записи")]
        public string Name { get; set; }

        public ICollection<Terminal> Terminals { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MaxLength(100,ErrorMessage ="Too many characters.")]
        public string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity_Vinicom.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string Url { get; set; }

        public int Rating { get; set; }

        public List<Post> Post { get; set; }
    }
}

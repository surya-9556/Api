using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public String BlogName { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
    }
}

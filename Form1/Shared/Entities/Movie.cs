using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        [Required]
        public string Title { get; set; }
        public string Poster { get; set; }
    }
}

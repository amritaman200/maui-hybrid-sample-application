using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_hybrid.Models
{
    public class MovieModel
    {
        public int id { get; set; }
        public string movie { get; set; }
        public double rating { get; set; }
        public string image { get; set; }
        public string imdb_url { get; set; }
    }
}

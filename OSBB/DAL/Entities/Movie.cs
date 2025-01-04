using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Movie
    {
      public int MovieId { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }
      public DateTime ReleaseDate { get; set; }
      public string Genre { get; set; }
      public string Director { get; set; }
      public double Rating { get; set; }
    }

}

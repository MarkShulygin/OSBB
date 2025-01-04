using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class MovieSession
    {
        public int MovieSessionId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime SessionTime { get; set; }
        public int HallNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallingApiWithRazor.Models
{
    public class TopGamesModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}

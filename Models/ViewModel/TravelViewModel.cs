using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelerAPI.Models.ViewModel
{
    public class TravelViewModel
    {
        public int TravelNo { get; set; }

        public string TravelName { get; set; }

        public string TravelDesc { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public decimal? Price { get; set; }
    }
}

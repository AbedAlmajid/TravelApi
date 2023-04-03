using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Models.SheredProp;

namespace TravelerAPI.Models
{
    public class Travel : CommonProp
    {
        
        public int TravelId { get; set; }

        public int TravelNo { get; set; }

        public string TravelName { get; set; }

        public string TravelDesc { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public decimal? Price { get; set; }
    }
}

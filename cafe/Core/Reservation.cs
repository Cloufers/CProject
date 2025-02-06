using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Core
{
    public class Reservation
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public int TableID { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Status { get; set; }
    }

}

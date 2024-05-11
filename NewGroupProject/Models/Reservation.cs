using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewGroupProject.Models
{
    public class Reservation
    {

        // this is my comment
        public int ReservationID { get; set; }
        public string ReservationName { get; set; }
        public int NoofGuests { get; set; }
        public string ReservationDate { get; set; }
        public string ReservationTime { get; set; }
    }
}
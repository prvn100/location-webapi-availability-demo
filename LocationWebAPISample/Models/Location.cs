using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationWebAPISample.Models
{
    
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string AvailableTimeSlot { get; set; }
        public bool IsSlotUnavailable { get; set; }
    }
}
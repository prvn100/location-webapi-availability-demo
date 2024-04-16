using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LocationWebAPISample.Models;
using System.Web.Http.Results;

namespace LocationWebAPISample.Controllers
{
    public class LocationController : ApiController
    {
        IList<Location> Locations = new List<Location>()
        {
            new Location()
                {
                    Id = 1, LocationName = "City Cafe", Address = "Pune", AvailableTimeSlot = "8 AM - 11 AM", State="MH",Country="INDIA",Zipcode="411030",IsSlotUnavailable=true
                },
                new Location()
                {
                    Id = 2, LocationName = "Cafe Goodluck", Address = "Pune", AvailableTimeSlot = "10 AM - 1 PM", State="MH",Country="INDIA",Zipcode="411025",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 3, LocationName = "Blue Heaven Cafe ", Address = "Laxmi Nagar,Pune", AvailableTimeSlot = "2 PM - 5 PM", State="MH",Country="INDIA",Zipcode="411020",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 4, LocationName = "Malaka Spice | Cafe", Address = "FC Road Pune", AvailableTimeSlot = "5 PM - 8 PM", State="MH",Country="INDIA",Zipcode="411007",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 5, LocationName = "Prem's Restaurant Bar & Cafe", Address = "MJ Road Pune", AvailableTimeSlot = "10 AM - 1 PM", State="MH",Country="INDIA",Zipcode="411002",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 6, LocationName = "Red Chilly Bar & Cafe", Address = "Shiavajinagar Pune", AvailableTimeSlot = "8 AM - 11 AM", State="MH",Country="INDIA",Zipcode="411005",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 7, LocationName = "McDonald", Address = "Vishrantwadi Pune", AvailableTimeSlot = "11 AM - 2 PM", State="MH",Country="INDIA",Zipcode="411009",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 8, LocationName = "KFC", Address = "Phoenix Mall Pune", AvailableTimeSlot = "2 PM - 5 PM", State="MH",Country="INDIA",Zipcode="411010",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 9, LocationName = "J J Restaurant | Bar | Cafe", Address = "Budhwar Peth Pune", AvailableTimeSlot = "5 PM - 8 PM", State="MH",Country="INDIA",Zipcode="411014",IsSlotUnavailable=false
                },
                new Location()
                {
                    Id = 10, LocationName = "JW Mariot", Address = "CENTRAL AVENUE ROAD PUNE", AvailableTimeSlot = "10 AM - 1 PM", State="MH",Country="INDIA",Zipcode="411015",IsSlotUnavailable=false
                },
        };

        
        public IList<Location> GetAllLocations()
        {
            //Return list of all Locations Ilist obj
            return Locations;

            // Then I return the list
           
        }
        
        public Location GetLocationDetails(int Id)
        {
            //Return a single Location detail
            var location = Locations.FirstOrDefault(e => e.Id == Id);
            if (location == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return location;
        }
    }
}

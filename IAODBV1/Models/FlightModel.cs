using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAODBV1.Models
{
    public class FlightModel
    {
       
        public string FlightId { get; set; }
        [Required(ErrorMessage ="You Must EnTer Flight Number")]
        public string FlightNo { get; set; }
        public DateTime FlightDate { get; set; }
        [Required(ErrorMessage = "You Must EnTer Flight Route")]
        public string Route { get; set; }

        [Required(ErrorMessage = "You Must EnTer ArrDep")]
        public string ArrDep { get; set; }
        public string Status { get; set; }
        public string DGATE { get; set; }//Gate Departure
        public string AGATE { get; set; }//Gate Arrival
        public string DPRK { get; set; }//ParkingBay Departure
        public string APRK { get; set; }//ParkingBay Arrival
        public string AcType { get; set; }
        public string AcRegNo { get; set; }
        public string FlightType { get; set; }
        public string Belt { get; set; }
        public string Terminal { get; set; }
        public string SOBT { get; set; }//ScheduledTime Departure
        public string SIBT { get; set; }//ScheduledTime Arrival
        public string ATOT { get; set; }//ActualTime Departure
        public string ALDT { get; set; }//ActualTime Arrival
        public string EOBT { get; set; }//ActualTime Departure
    }
}

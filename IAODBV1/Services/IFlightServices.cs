using IAODBV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAODBV1.Services
{
    public interface IFlightServices
    {
        Task<List<FlightModel>> GetAllFlight();
        Task<bool> AddFlight(FlightModel model);

        Task<FlightModel> UpdateFlight(string FlightID,FlightModel model);



        Task<bool> DeleteFlight(FlightModel model);
        Task<FlightModel> GetFlightDetailByFlightID(string FlightID);
    }
}

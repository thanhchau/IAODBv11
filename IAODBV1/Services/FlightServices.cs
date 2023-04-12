using IAODBV1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAODBV1.Services
{
    public class FlightServices : IFlightServices
    {
        private string _baseUrl = "https://6433b0e6582420e231693d9b.mockapi.io";
        public Task<bool> AddFlight(FlightModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFlight(FlightModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FlightModel>> GetAllFlight()
        {
            string url = $"{_baseUrl}/Flys";
            var returnResponse = new List<FlightModel>();
            using(var client = new HttpClient())
            {
                client.GetAsync(url);
                var apiResponse = await client.GetAsync(url);
                if(apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response =await apiResponse.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<List<FlightModel>>(response.ToString());
                    return returnResponse;
                }
                else
                {
                    return returnResponse;

                }
               
            }
        }

        public Task<FlightModel> UpdateFlight(FlightModel model)
        {
            throw new NotImplementedException();
        }
    }
}

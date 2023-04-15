using IAODBV1.Models;
using Microsoft.Maui.Graphics.Text;
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
        public async Task<bool> AddFlight(FlightModel model)
        {
            string url = $"{_baseUrl}/Flys";
            var returnResponse = new FlightModel();
            using (var client = new HttpClient())
            {
                var serializeContent = JsonConvert.SerializeObject(model);
                var apiResponse = await client.PostAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));
                if (apiResponse.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<FlightModel>(response);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
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

        
        public async Task<FlightModel> UpdateFlight(string FlightID, FlightModel model)
        {
            string url = $"{_baseUrl}/Flys/" + FlightID;
            var serializeContent = JsonConvert.SerializeObject(model);
            var returnResponse = new FlightModel();
            try
            {
                using (var client = new HttpClient())
                {
                    var apiResponse = await client.PutAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));
                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<FlightModel>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }


            return returnResponse;
        }
        public async Task<FlightModel> GetFlightDetailByFlightID(string FlightID)
        {
            string url = $"{_baseUrl}/Flys/" + FlightID;
            var returnResponse = new FlightModel();
            try
            {
                using (var client = new HttpClient())
                {
                    var apiResponse = await client.GetAsync(url);
                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<FlightModel>(response.ToString());
                    }
                       

                }

            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;

        }

    }
}

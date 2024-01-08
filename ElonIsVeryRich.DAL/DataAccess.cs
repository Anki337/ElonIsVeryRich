using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



namespace ElonIsVeryRich.DAL
{
    public class DataAccess
    {


        public async Task <List<RootModel?>> GetLaunchData()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.spacexdata.com/v3/launches");
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<RootModel?> apiData = JsonConvert.DeserializeObject<List<RootModel?>>(jsonResponse);
                return apiData!;
            }
            else
            {
                return null;
            }
            
        }

        public async Task<List<RootRocketModel?>> GetRocketData()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.spacexdata.com/v3/rockets");
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<RootRocketModel?> apiRocketData = JsonConvert.DeserializeObject<List<RootRocketModel?>>(jsonResponse);
                return apiRocketData!;
            }
            else
            {
                return null;
            }

        }


    }
}

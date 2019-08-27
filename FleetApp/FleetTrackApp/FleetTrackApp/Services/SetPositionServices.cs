using FleetTrackApp.Model;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FleetTrackApp.Services
{
    public class SetPositionServices
    {
        public string ApiKey { get; set; }
        //public async void SetApiKey()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {

        //        try
        //        {
        //            if (ApiKey != null)
        //            {
        //                var response = await client.GetStringAsync(ApiKey);

        //                var DataModel = JsonConvert.DeserializeObject<List<LocationInfo>>(response);

        //                //Custome code here 
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            Console.WriteLine("Big Error " + ex);
        //        }

        //    }
        //}

    }
}

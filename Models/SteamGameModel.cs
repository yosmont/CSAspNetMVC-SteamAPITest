using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json.Linq;

namespace test1.Models
{
    public class SteamGameModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Dev { get; set; }

        public SteamGameModel(int id)
        {
            ID = id;
            using (WebClient wc = new WebClient())
            {
                JObject json = JObject.Parse(wc.DownloadString("https://store.steampowered.com/api/appdetails?appids=" + id.ToString()));
                if ((bool)json[id.ToString()]["success"] == false)
                {
                    id = 366920;
                    json = JObject.Parse(wc.DownloadString("https://store.steampowered.com/api/appdetails?appids=" + id.ToString()));
                }
                Name = json[id.ToString()]["data"]["name"].ToString();
                ShortDesc = json[id.ToString()]["data"]["short_description"].ToString();
                Dev = json[id.ToString()]["data"]["developers"][0].ToString();
            }
        }
    }
}
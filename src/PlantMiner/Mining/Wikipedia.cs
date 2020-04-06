using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PlantMiner.Mining
{
    public class Wikipedia
    {
        private static readonly HttpClient client = new HttpClient(new HttpClientHandler()
        {
            //Credentials = new NetworkCredential(
            //    App.Configuration.GetValue<string>("TygronUser"),
            //    App.Configuration.GetValue<string>("TygronPass"))
        });

        static Wikipedia()
        {
            client.BaseAddress = new Uri("http://www.wikidata.org/w/api.php");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task GetSectionData(string section)
        {
            try
            {
                HttpResponseMessage result = await client.GetAsync($"/w/api.php?action=parse&format=json&page=Plant&prop=sections");
                if (result.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<JObject>(await result.Content.ReadAsStringAsync());

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
